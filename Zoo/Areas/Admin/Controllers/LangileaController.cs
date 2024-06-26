using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text.Encodings.Web;
using System.Text;
using Zoo.Data;
using Zoo.Models;
using Zoo.Models.ViewModels;
using Zoo.Repository;
using Zoo.Repository.IRepository;
using Zoo.Utility;

using Microsoft.AspNetCore.Authentication;


namespace Zoo.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class LangileaController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _UnitOfWork;
        public LangileaController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _UnitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Langile> objLangileList = _UnitOfWork.Langilea.GetAll().ToList();
            return View(objLangileList);
        }

        public IActionResult edit(string ID)
        {
            
                
                Langile Langilea = _UnitOfWork.Langilea.Get(u => u.Id == ID);
                return View(Langilea);
            
        }

        [HttpPost]

        public IActionResult edit(Langile Langilea)
        {
            if (ModelState.IsValid)
            {
                _UnitOfWork.Langilea.Update(Langilea);
                _UnitOfWork.Save();
                TempData["success"] = "Langilea ondo Aldatuta";
                return RedirectToAction("Index");
            }
            else
            {
                return View(Langilea);
            }
        }

        #region API CALLS
        [HttpGet]
            public IActionResult GetAll()
            {
                List<Langile> objLangileList = _UnitOfWork.Langilea.GetAll().ToList();
                return Json(new { data = objLangileList });
            }

            [HttpDelete]
            public IActionResult Delete(string? id)
            {
                var LangileToBeDeleted = _UnitOfWork.Langilea.Get(u => u.Id == id);
                if (LangileToBeDeleted == null)
                {
                    return Json(new { succes = false, message = "Error while deleting" });
                }


                _UnitOfWork.Langilea.Remove(LangileToBeDeleted);
                _UnitOfWork.Save();

                return Json(new { succes = true, message = "Delete Successful" });
            }

            #endregion

        }
    }


