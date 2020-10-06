using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class BlogController : Controller
    {
        [Route("blog")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("blog-left-sidebar")]
        public IActionResult BlogLeftSidebar()
        {
            return View();
        }
    }
}
