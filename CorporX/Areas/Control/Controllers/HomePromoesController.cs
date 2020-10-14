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
    public class HomePromoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomePromoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/HomePromoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomePromo.ToListAsync());
        }

        // GET: Control/HomePromoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePromo = await _context.HomePromo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePromo == null)
            {
                return NotFound();
            }

            return View(homePromo);
        }

        // GET: Control/HomePromoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomePromoes/Create.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Icon,Id,Title,Content")] HomePromo homePromo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homePromo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homePromo);
        }

        // GET: Control/HomePromoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePromo = await _context.HomePromo.FindAsync(id);
            if (homePromo == null)
            {
                return NotFound();
            }
            return View(homePromo);
        }

        // POST: Control/HomePromoes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Icon,Id,Title,Content")] HomePromo homePromo)
        {
            if (id != homePromo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homePromo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePromoExists(homePromo.Id))
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
            return View(homePromo);
        }

        // GET: Control/HomePromoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePromo = await _context.HomePromo
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePromo == null)
            {
                return NotFound();
            }

            return View(homePromo);
        }

        // POST: Control/HomePromoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homePromo = await _context.HomePromo.FindAsync(id);
            _context.HomePromo.Remove(homePromo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomePromoExists(int id)
        {
            return _context.HomePromo.Any(e => e.Id == id);
        }
    }
}
