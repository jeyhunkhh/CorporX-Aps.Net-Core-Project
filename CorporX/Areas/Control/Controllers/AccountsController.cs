using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models;
using CorporX.Filters;
using CryptoHelper;
using CorporX.Areas.Control.Models;

namespace CorporX.Areas.Control.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Control")]
    public class AccountsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/Accounts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Accounts.ToListAsync());
        }

        // GET: Control/Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Control/Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/Accounts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateAccountViewModel createAccount)
        {
            if (_context.Accounts.Any(u => u.Email == createAccount.Email))
            {
                ModelState.AddModelError("EmailUnique", "This email is already registered");
            }

            if (ModelState.IsValid)
            {
                Account account = new Account
                {
                    FullName = createAccount.FullName,
                    Email = createAccount.Email,
                    Password = Crypto.HashPassword(createAccount.Password)
                };

                _context.Accounts.Add(account);

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(createAccount);
        }

        // GET: Control/Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Control/Accounts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Email")] EditAccountViewModel account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var userdb = _context.Accounts.FirstOrDefault(x => x.Id == id);
                    if(userdb == null)
                    {
                        return NotFound();
                    }

                    userdb.FullName = account.FullName;
                    userdb.Email = account.Email;

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }

        // GET: Control/Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Control/Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Accounts.FindAsync(id);
            _context.Accounts.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Accounts.Any(e => e.Id == id);
        }
    }
}
