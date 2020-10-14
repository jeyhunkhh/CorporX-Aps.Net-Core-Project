using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models.Home;
using CorporX.Filters;

namespace CorporX.Areas.Control.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Control")]
    public class HomeServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/HomeServices
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeServices.ToListAsync());
        }

        // GET: Control/HomeServices/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeServices = await _context.HomeServices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeServices == null)
            {
                return NotFound();
            }

            return View(homeServices);
        }

        // GET: Control/HomeServices/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeServices/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content")] HomeServices homeServices)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeServices);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeServices);
        }

        // GET: Control/HomeServices/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeServices = await _context.HomeServices.FindAsync(id);
            if (homeServices == null)
            {
                return NotFound();
            }
            return View(homeServices);
        }

        // POST: Control/HomeServices/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] HomeServices homeServices)
        {
            if (id != homeServices.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeServices);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeServicesExists(homeServices.Id))
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
            return View(homeServices);
        }

        // GET: Control/HomeServices/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeServices = await _context.HomeServices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeServices == null)
            {
                return NotFound();
            }

            return View(homeServices);
        }

        // POST: Control/HomeServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeServices = await _context.HomeServices.FindAsync(id);
            _context.HomeServices.Remove(homeServices);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeServicesExists(int id)
        {
            return _context.HomeServices.Any(e => e.Id == id);
        }
    }
}
