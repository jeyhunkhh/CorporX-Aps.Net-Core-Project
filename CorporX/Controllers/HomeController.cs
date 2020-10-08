using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CorporX.Models;
using CorporX.ViewModels;
using CorporX.Data;

namespace CorporX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["navbartype"] = "home";

            HomeViewModel homeViewModel = new HomeViewModel
            {
                HomeAboutUs = _context.HomeAboutUs.FirstOrDefault(),
                HomeBlog = _context.HomeBlog.FirstOrDefault(),
                HomeBlogItem = _context.HomeBlogItem.ToList(),
                HomeCallToAction = _context.HomeCallToAction.FirstOrDefault(),
                HomeHeader = _context.HomeHeader.FirstOrDefault(),
                HomePromo = _context.HomePromo.ToList(),
                HomeTeam = _context.HomeTeam.FirstOrDefault(),
                HomeTestimonial = _context.HomeTestimonial.FirstOrDefault(),
                HomeTestimonialItem = _context.HomeTestimonialItem.ToList(),
                HomePortfolio = _context.HomePortfolio.FirstOrDefault(),
                HomeServices = _context.HomeServices.FirstOrDefault(),
                ServicesDetails = _context.ServicesDetail.ToList(),
                ProjectDetails = _context.ProjectDetails.ToList(),
                TeamItems = _context.TeamItems.ToList()
            };

            
            return View(homeViewModel);
        }
    }
}
