using CorporX.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Areas.Control.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Control")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
