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
                ProjectDetails = _context.ProjectDetails.ToList()
            };
            return View(projectViewModel);
        }

        [Route("project-details")]
        public IActionResult ProjectDetails()
        {
            return View();
        }
    }
}
