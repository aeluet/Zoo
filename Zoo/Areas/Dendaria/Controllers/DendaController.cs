using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zoo.Utility;

namespace Zoo.Areas.Dendaria.Controllers
{
    [Area("Dendaria")]
    [Authorize(Roles = SD.Role_Denda)]
    public class DendaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
