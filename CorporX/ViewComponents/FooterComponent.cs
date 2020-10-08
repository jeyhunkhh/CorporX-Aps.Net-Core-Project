using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;

namespace CorporX.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public FooterComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke()
        {
            var footer = _context.Setting.FirstOrDefault();

            return View(footer);
        }
    }
}
