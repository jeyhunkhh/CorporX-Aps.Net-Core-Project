using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class Error404 : Controller
    {
        [Route("404")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
