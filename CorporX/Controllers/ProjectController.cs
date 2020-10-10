using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Route("project")]
        public IActionResult Index()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel
            {
                ProjectDetails = _context.ProjectDetails.ToList(),
                SliderItems = _context.SliderItems.ToList(),
                Clients = _context.Clients.ToList(),
                PricingItems = _context.PricingItems.ToList(),
                Pricings = _context.Pricings.ToList(),
                BreadcrumbViewModel = new BreadcrumbViewModel
                {
                    Title = "Our Projects",
                    Links = new List<string>
                    {
                        "Home,home,index",
                        "Projects,project,index"
                    }
                }
            };
            return View(projectViewModel);
        }

        [Route("project-details")]
        public IActionResult ProjectDetails(int Id)
        {
            if(!_context.ProjectDetails.Any(x=>x.Id == Id))
            {
                return RedirectToAction("index", "error404");
            }

            ProjectDetialsViewModel projectDetialsViewModel = new ProjectDetialsViewModel
            {
                ProjectDetails = _context.ProjectDetails.FirstOrDefault(x => x.Id == Id),
                BreadcrumbViewModel = new BreadcrumbViewModel
                {
                    Title = "Project Details",
                    Links = new List<string>
                    {
                        "Home,home,index",
                        "Projects,project,index",
                        "Project Details,project,projectdetails"
                    }
                }
            };

            return View(projectDetialsViewModel);
        }
    }
}
