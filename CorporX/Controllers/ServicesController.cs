using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("services")]
        public IActionResult Index()
        {
            ServicesDetialsViewModel DetialsViewModel = new ServicesDetialsViewModel
            {
                ServicesDetails = _context.ServicesDetail.ToList(),
            };
            return View(DetialsViewModel);
        }

        [Route("services-details")]
        public IActionResult ServicesDetails()
        {
           
            return View();
        }
    }
}
