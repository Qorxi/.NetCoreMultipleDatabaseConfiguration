using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PostgreCore.Contexts;
using PostgreCore.DataBaseContexts;

namespace PostgreCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDBContext dBContext = null;

        public HomeController(IDBContext dbcontex)
        {
            dBContext = dbcontex;
        }


        public IActionResult Index()
        {
            var list = dBContext.ProdSearchables.ToList();
            return View(list);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PostgreCore.Models.ProdSearchable model)
        {
            dBContext.ProdSearchables.Add(model);
            dBContext.SaveContextChanges();
            return RedirectToAction("Index");
        }

    }
}