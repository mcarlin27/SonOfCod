using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SonOfCod.Models;

namespace SonOfCod.Controllers
{
    public class RecipientsController : Controller
    {
        private SonOfCodDbContext db = new SonOfCodDbContext();
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Recipient recipient)
        {
            db.Recipients.Add(recipient);
            db.SaveChanges();
            return RedirectToAction("Create");
        }
    }
}
