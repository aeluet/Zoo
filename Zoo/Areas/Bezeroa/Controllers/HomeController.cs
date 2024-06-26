using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Zoo.Models;
using Zoo.Repository.IRepository;

namespace Zoo.Areas.Bezeroa.Controllers
{
    [Area("Bezeroa")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IUnitOfWork _UnitOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _UnitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Arraza> objArrazaList = _UnitOfWork.Arraza.GetAll(includeProperties: "Lekua").ToList();
            return View(objArrazaList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ListAnimalia(int? id)
        {
            List<Animalia> objAnimaliaList = _UnitOfWork.Animalia.GetPartial(u => u.ID_arraza == id, includeProperties: "Arraza").ToList();
            return View(objAnimaliaList);
        }
    }
}
