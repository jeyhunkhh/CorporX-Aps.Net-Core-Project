using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ThanksController : Controller
    {
        [Route("thankyou")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
