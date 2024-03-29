﻿using System;
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
        private readonly IDbContext dBContext = null;

        public HomeController(IDbContext dbcontex)
        {
            dBContext = dbcontex;
        }


        public IActionResult Index()
        {
            var list = dBContext.Employees.ToList();
            return View(list);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PostgreCore.Models.Employee model)
        {
            dBContext.Employees.Add(model);
            dBContext.SaveContextChanges();
            return RedirectToAction("Index");
        }

    }
}