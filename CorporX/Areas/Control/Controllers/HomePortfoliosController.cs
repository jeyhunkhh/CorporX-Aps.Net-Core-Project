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
    public class HomePortfoliosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomePortfoliosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/HomePortfolios
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomePortfolio.ToListAsync());
        }

        // GET: Control/HomePortfolios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePortfolio = await _context.HomePortfolio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePortfolio == null)
            {
                return NotFound();
            }

            return View(homePortfolio);
        }

        // GET: Control/HomePortfolios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomePortfolios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content")] HomePortfolio homePortfolio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homePortfolio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homePortfolio);
        }

        // GET: Control/HomePortfolios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePortfolio = await _context.HomePortfolio.FindAsync(id);
            if (homePortfolio == null)
            {
                return NotFound();
            }
            return View(homePortfolio);
        }

        // POST: Control/HomePortfolios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] HomePortfolio homePortfolio)
        {
            if (id != homePortfolio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homePortfolio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomePortfolioExists(homePortfolio.Id))
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
            return View(homePortfolio);
        }

        // GET: Control/HomePortfolios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homePortfolio = await _context.HomePortfolio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homePortfolio == null)
            {
                return NotFound();
            }

            return View(homePortfolio);
        }

        // POST: Control/HomePortfolios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homePortfolio = await _context.HomePortfolio.FindAsync(id);
            _context.HomePortfolio.Remove(homePortfolio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomePortfolioExists(int id)
        {
            return _context.HomePortfolio.Any(e => e.Id == id);
        }
    }
}
