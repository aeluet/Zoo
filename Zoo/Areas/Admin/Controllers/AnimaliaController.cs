using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Zoo.Data;
using Zoo.Models;
using Zoo.Models.ViewModels;
using Zoo.Repository;
using Zoo.Repository.IRepository;
using Zoo.Utility;

namespace Zoo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class AnimaliaController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _UnitOfWork;
        public AnimaliaController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Animalia> objAnimaliaList = _UnitOfWork.Animalia.GetAll(includeProperties: "Arraza").ToList();
            return View(objAnimaliaList);
        }

        
        public IActionResult Upsert(int? ID)
        {
            AnimaliaVM animaliaVM = new()
            {
                ArrazaList = _UnitOfWork.Arraza.GetAll().ToList().Select(u => new SelectListItem
                {
                    Text = u.Izena,
                    Value = u.ID.ToString()
                }),
                Animalia = new Animalia()
            };
            if (ID == null)
            {
                //create
                return View(animaliaVM);
            }
            else
            {
                //update
                animaliaVM.Animalia = _UnitOfWork.Animalia.Get(u => u.ID == ID);
                return View(animaliaVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(AnimaliaVM AnimaliaVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string animaliaPath = Path.Combine(wwwRootPath, @"images\animalia");
                    if (!string.IsNullOrEmpty(AnimaliaVM.Animalia.ImageUrl))
                    {
                        //Delete the old image in the update
                        var oldImagePath = Path.Combine(wwwRootPath, AnimaliaVM.Animalia.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(animaliaPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    AnimaliaVM.Animalia.ImageUrl = @"\images\animalia\" + fileName;
                }
                if (AnimaliaVM.Animalia.ID == 0)
                {
                    _UnitOfWork.Animalia.Add(AnimaliaVM.Animalia);
                }
                else
                {
                    _UnitOfWork.Animalia.Update(AnimaliaVM.Animalia);
                }
                _UnitOfWork.Save();
                TempData["success"] = "Animalia ondo sortuta";
                return RedirectToAction("Index");
            }
            else
            {
                AnimaliaVM.ArrazaList = _UnitOfWork.Arraza.GetAll().ToList().Select(u => new SelectListItem
                {
                    Text = u.Izena,
                    Value = u.ID.ToString()
                });
                return View(AnimaliaVM);
            }



        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Animalia> objAnimaliaList = _UnitOfWork.Animalia.GetAll(includeProperties: "Arraza").ToList();
            return Json(new { data = objAnimaliaList });

        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var AnimaliaToBeDeleted = _UnitOfWork.Animalia.Get(u => u.ID == id);
            if (AnimaliaToBeDeleted == null)
            {
                return Json(new { succes = false, message = "Error while deleting" });
            }
            var oldImagePath =
                            Path.Combine(_webHostEnvironment.WebRootPath,
                            AnimaliaToBeDeleted.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _UnitOfWork.Animalia.Remove(AnimaliaToBeDeleted);
            _UnitOfWork.Save();

            return Json(new { succes = true, message = "Delete Successful" });
        }

        #endregion

    }
}


