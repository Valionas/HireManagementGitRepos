﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HireManagement.Models;
using HireManagement.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HireManagement.Controllers
{
    public class WorkerController : Controller
    {
     
        private readonly HireContext _context;
        public WorkerController(HireContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Worker worker)
        {
       
            if (ModelState.IsValid)
            {
                _context.Workers.Add(worker);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
