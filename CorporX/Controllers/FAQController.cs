using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class FAQController : Controller
    {
        private readonly ApplicationDbContext _context;
        public FAQController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("faq")]
        public IActionResult Index()
        {
            FAQViewModel FAQViewModel = new FAQViewModel
            {
                PricingFAQs = _context.PricingFAQs.ToList(),
                FAQs = _context.FAQs.ToList()
            };

            return View(FAQViewModel);
        }
    }
}
