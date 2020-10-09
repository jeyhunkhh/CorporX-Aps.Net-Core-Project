using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Data;
using CorporX.Models.Services;
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
            ServicesViewModel ServicesViewModel = new ServicesViewModel
            {
                ServicesDetails = _context.ServicesDetail.ToList(),
                Clients = _context.Clients.ToList(),
                ServicesDetailsHeaders = _context.ServicesDetailsHeaders.FirstOrDefault(),
                ServisPromos = _context.ServisPromos.ToList(),
                Settings = _context.Setting.FirstOrDefault()
            };

            return View(ServicesViewModel);
        }

        [HttpPost]
        [Route("services")]
        public IActionResult Send(ServicesViewModel model)
        {
            if (ModelState.IsValid)
            {
                Message message = new Message
                {
                    FullName = model.Message.FullName,
                    Email = model.Message.Email,
                    MessageText = model.Message.MessageText
                };

                _context.Messages.Add(message);
                _context.SaveChanges();

                return RedirectToAction("index", "services");
            }

            return NoContent();   
        }


        [Route("services-details")]
        public IActionResult ServicesDetails(int Id)
        {
            if (!_context.ServicesDetail.Any(x => x.Id == Id))
            {
                return RedirectToAction("index", "error404");
            }

            ServicesDetialsViewModel servicesDetialsViewModel = new ServicesDetialsViewModel
            {
                ServicesDetails = _context.ServicesDetail.FirstOrDefault(x=>x.Id == Id)
            };

            return View(servicesDetialsViewModel);
        }
    }
}
