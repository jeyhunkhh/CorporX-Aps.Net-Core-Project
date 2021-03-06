﻿using CorporX.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System.Linq;

namespace CorporX.ViewComponents
{
    public class HeaderComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public HeaderComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public ViewViewComponentResult Invoke()
        {
            var header = _context.Setting.FirstOrDefault();

            return View(header);
        }
    }
}
