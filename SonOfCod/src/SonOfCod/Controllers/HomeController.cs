using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class HomeController : Controller
    {
        private readonly SonOfCodDbContext _db;

        public HomeController(SonOfCodDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Marketing()
        {
            return View();
        }
    }
}