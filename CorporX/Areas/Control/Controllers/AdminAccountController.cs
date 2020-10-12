using System;
using System.Linq;
using System.Threading.Tasks;
using CorporX.Areas.Control.Models;
using CorporX.Data;
using CorporX.Models;
using CryptoHelper;
using Microsoft.AspNetCore.Mvc;

namespace CorporX.Areas.Control.Controllers
{
    
    [Area("Control")]
    public class AdminAccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AdminAccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                ControlAccount user = _context.ControlAccounts.FirstOrDefault(u => u.Email == model.Email);

                if(user != null)
                {
                    if (Crypto.VerifyHashedPassword(user.Password, model.Password))
                    {
                        user.Token = Crypto.HashPassword(DateTime.Now.ToString());
                        await _context.SaveChangesAsync();
                    }

                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        Expires = DateTime.Now.AddMinutes(30),
                        HttpOnly = true
                    });

                    return RedirectToAction("index", "home");
                }
            }

            return View(model);
        }


        public IActionResult LogOut(int Id)
        {
            ControlAccount user = _context.ControlAccounts.FirstOrDefault(x=>x.Id == Id);

            if(user != null)
            {
                user.Token = "Null";
                return RedirectToAction("index", "adminaccount");
            }

            return NoContent();
        }
    }
}
