using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ServicesController : Controller
    {
        [Route("services")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("services-details")]
        public IActionResult ServicesDetails()
        {
            return View();
        }
    }
}
