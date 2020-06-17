﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello";
        }

        public IActionResult About()
        {
            return View();
        }

        // Add from New NextBranch
        public IActionResult Details()
        {
            return View();
        }
    }
}