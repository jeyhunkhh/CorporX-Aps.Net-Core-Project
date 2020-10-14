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
    public class HomeTestimonialsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeTestimonialsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/HomeTestimonials
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeTestimonial.ToListAsync());
        }

        // GET: Control/HomeTestimonials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTestimonial = await _context.HomeTestimonial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeTestimonial == null)
            {
                return NotFound();
            }

            return View(homeTestimonial);
        }

        // GET: Control/HomeTestimonials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeTestimonials/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content")] HomeTestimonial homeTestimonial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeTestimonial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeTestimonial);
        }

        // GET: Control/HomeTestimonials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTestimonial = await _context.HomeTestimonial.FindAsync(id);
            if (homeTestimonial == null)
            {
                return NotFound();
            }
            return View(homeTestimonial);
        }

        // POST: Control/HomeTestimonials/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] HomeTestimonial homeTestimonial)
        {
            if (id != homeTestimonial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeTestimonial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeTestimonialExists(homeTestimonial.Id))
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
            return View(homeTestimonial);
        }

        // GET: Control/HomeTestimonials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTestimonial = await _context.HomeTestimonial
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeTestimonial == null)
            {
                return NotFound();
            }

            return View(homeTestimonial);
        }

        // POST: Control/HomeTestimonials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeTestimonial = await _context.HomeTestimonial.FindAsync(id);
            _context.HomeTestimonial.Remove(homeTestimonial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeTestimonialExists(int id)
        {
            return _context.HomeTestimonial.Any(e => e.Id == id);
        }
    }
}
