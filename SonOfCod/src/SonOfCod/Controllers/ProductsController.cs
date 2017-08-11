using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SonOfCod.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


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
