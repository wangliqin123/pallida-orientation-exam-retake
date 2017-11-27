﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FashionWebStoreApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/warehouse")]
        public IActionResult Index()
        {
            return View(FashionStoreService.GetWarehouseItemList());
        }

        [HttpPost]
        [Route("/warehouse/summary")]
        public IActionResult Summary()
        {
            return View();
        }

        [HttpGet]
        [Route("/warehouse/query")]
        public IActionResult ApiQuery()
        {
            return Json(new { result = "ok", data = });
        }
        

    }
}