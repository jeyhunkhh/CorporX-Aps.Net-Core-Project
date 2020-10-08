using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.Models.AboutUs;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AboutUsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("about-us")]
        public IActionResult Index()
        {
            AboutUsViewModel aboutUsViewModel = new AboutUsViewModel
            {
                AboutUsTeam = _context.AboutUsTeams.FirstOrDefault(),
                TeamItems = _context.TeamItems.ToList(),
                AboutUsMission = _context.AboutUsMissions.FirstOrDefault(),
                AboutUsPromo = _context.AboutUsPromos.ToList(),
                AboutUsSliderHeader = _context.AboutUsSliderHeaders.FirstOrDefault(),
                AboutUsWorkProcess = _context.AboutUsWorkProcesses.FirstOrDefault(),
                AboutUsWorkProcessItems = _context.AboutUsWorkProcessItems.ToList(),
                Clients = _context.Clients.ToList(),
                SliderItems = _context.SliderItems.ToList()
            };

            return View(aboutUsViewModel);
        }
    }
}
