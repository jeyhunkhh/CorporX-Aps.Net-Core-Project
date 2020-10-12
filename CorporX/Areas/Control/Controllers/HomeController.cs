using CorporX.Filters;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Areas.Control.Controllers
{
    
    [Area("Control")]
    public class HomeController : Controller
    {
        
        [TypeFilter(typeof(Auth))]
        public IActionResult Index()
        {
            return View();
        }
    }
}
