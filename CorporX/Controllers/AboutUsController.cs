﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class AboutUsController : Controller
    {
        [Route("about-us")]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}