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
    public class ArrazaController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _UnitOfWork;
        public ArrazaController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Arraza> objArrazaList = _UnitOfWork.Arraza.GetAll(includeProperties: "Lekua").ToList();
            return View(objArrazaList);
        }

        
        public IActionResult Upsert(int? ID)
        {
            ArrazaVM arrazaVM = new()
            {
                LekuakList = _UnitOfWork.Lekua.GetAll().ToList().Select(u => new SelectListItem
                {
                    Text = u.Izena,
                    Value = u.ID.ToString()
                }),
                Arraza = new Arraza()
            };
            if (ID == null)
            {
                //create
                return View(arrazaVM);
            }
            else
            {
                //update
                arrazaVM.Arraza = _UnitOfWork.Arraza.Get(u => u.ID == ID);
                return View(arrazaVM);
            }
        }
        [HttpPost]
        public IActionResult Upsert(ArrazaVM arrazaVM, IFormFile? file)
        {
            if (ModelState.IsValid)
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string arrazaPath = Path.Combine(wwwRootPath, @"images\arraza");
                    if (!string.IsNullOrEmpty(arrazaVM.Arraza.ImageUrl))
                    {
                        //Delete the old image in the update
                        var oldImagePath = Path.Combine(wwwRootPath, arrazaVM.Arraza.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    using (var fileStream = new FileStream(Path.Combine(arrazaPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }
                    arrazaVM.Arraza.ImageUrl = @"\images\arraza\" + fileName;
                }
                if (arrazaVM.Arraza.ID == 0)
                {
                    _UnitOfWork.Arraza.Add(arrazaVM.Arraza);
                }
                else
                {
                    _UnitOfWork.Arraza.Update(arrazaVM.Arraza);
                }
                _UnitOfWork.Save();
                TempData["success"] = "Arraza ondo sortuta";
                return RedirectToAction("Index");
            }
            else
            {
                arrazaVM.LekuakList = _UnitOfWork.Lekua.GetAll().ToList().Select(u => new SelectListItem
                {
                    Text = u.Izena,
                    Value = u.ID.ToString()
                });
                return View(arrazaVM);
            }



        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Arraza> objArrazaList = _UnitOfWork.Arraza.GetAll(includeProperties: "Lekua").ToList();
            return Json(new { data = objArrazaList });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var ArrazaToBeDeleted = _UnitOfWork.Arraza.Get(u => u.ID == id);
            if (ArrazaToBeDeleted == null)
            {
                return Json(new { succes = false, message = "Error while deleting" });
            }
            var oldImagePath =
                            Path.Combine(_webHostEnvironment.WebRootPath,
                            ArrazaToBeDeleted.ImageUrl.TrimStart('\\'));

            if (System.IO.File.Exists(oldImagePath))
            {
                System.IO.File.Delete(oldImagePath);
            }

            _UnitOfWork.Arraza.Remove(ArrazaToBeDeleted);
            _UnitOfWork.Save();

            return Json(new { succes = true, message = "Delete Successful" });
        }

        #endregion

    }
}


