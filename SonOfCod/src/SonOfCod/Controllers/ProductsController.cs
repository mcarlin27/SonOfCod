using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;


namespace SonOfCod.Controllers
{
    public class ProductsController : Controller
    {
        private SonOfCodDbContext db = new SonOfCodDbContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public IActionResult Details(int id)
        {
            Product thisProduct = db.Products.FirstOrDefault(products => products.ProductId == id);
            return View(thisProduct);
        }
    }
}
