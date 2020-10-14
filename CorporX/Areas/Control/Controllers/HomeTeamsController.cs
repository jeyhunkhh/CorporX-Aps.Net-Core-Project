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
    public class HomeTeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeTeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/HomeTeams
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeTeam.ToListAsync());
        }

        // GET: Control/HomeTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTeam = await _context.HomeTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeTeam == null)
            {
                return NotFound();
            }

            return View(homeTeam);
        }

        // GET: Control/HomeTeams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeTeams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content")] HomeTeam homeTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeTeam);
        }

        // GET: Control/HomeTeams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTeam = await _context.HomeTeam.FindAsync(id);
            if (homeTeam == null)
            {
                return NotFound();
            }
            return View(homeTeam);
        }

        // POST: Control/HomeTeams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] HomeTeam homeTeam)
        {
            if (id != homeTeam.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeTeamExists(homeTeam.Id))
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
            return View(homeTeam);
        }

        // GET: Control/HomeTeams/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeTeam = await _context.HomeTeam
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeTeam == null)
            {
                return NotFound();
            }

            return View(homeTeam);
        }

        // POST: Control/HomeTeams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeTeam = await _context.HomeTeam.FindAsync(id);
            _context.HomeTeam.Remove(homeTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeTeamExists(int id)
        {
            return _context.HomeTeam.Any(e => e.Id == id);
        }
    }
}
