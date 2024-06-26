using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Zoo.Utility;

namespace Zoo.Areas.Zaintzailea.Controllers
{
    [Area("Zaintzailea")]
    [Authorize(Roles = SD.Role_Zain)]
    public class ZaintzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
