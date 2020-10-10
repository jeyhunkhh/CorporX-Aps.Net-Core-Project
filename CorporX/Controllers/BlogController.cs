using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BlogController(ApplicationDbContext context)
        {
            _context = context;
        }

        [Route("blog")]
        public IActionResult Index(int p = 1)
        {
            int pagesize = 6;
            int blogcount = _context.HomeBlogItem.Count();

            BlogViewModel blogViewModel = new BlogViewModel
            {
                HomeBlogItems = _context.HomeBlogItem.Skip((p-1)*pagesize).Take(pagesize).ToList(),
                BreadcrumbViewModel = new BreadcrumbViewModel
                {
                    Title = "Blog Default",
                    Links = new List<string>
                    {
                        "Home,home,index",
                        "Blog Default,blog,index"
                    }
                }
            };

            decimal pagecount = Math.Floor(((decimal)(blogcount / pagesize))+ 1);
            ViewData["Pagecount"] = pagecount ;

            return View(blogViewModel);
        }

        [Route("blog-left-sidebar")]
        public IActionResult BlogLeftSidebar(int p =1)
        {
            int pagesize = 3;
            int blogcount = _context.BlogLefts.Count();
            BlogLeftViewModel blogLeftViewModel = new BlogLeftViewModel
            {
                BlogLefts = _context.BlogLefts.Skip((p - 1) * pagesize).Take(pagesize).ToList(),
                BreadcrumbViewModel = new BreadcrumbViewModel
                {
                    Title = "Blog Left Sidebar",
                    Links = new List<string>
                    {
                        "Home,home,index",
                        "Blog Left Sidebar,blog,blogleftsidebar"
                    }
                }
            };

            decimal pagecount = Math.Floor(((decimal)(blogcount / pagesize)) + 1);
            ViewData["Pagecount"] = pagecount;

            return View(blogLeftViewModel);
        }
    }
}
