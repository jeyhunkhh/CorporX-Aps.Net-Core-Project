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
    public class HomeBlogsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeBlogsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Control/HomeBlogs
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeBlog.ToListAsync());
        }

        // GET: Control/HomeBlogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeBlog = await _context.HomeBlog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeBlog == null)
            {
                return NotFound();
            }

            return View(homeBlog);
        }

        // GET: Control/HomeBlogs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeBlogs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content")] HomeBlog homeBlog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(homeBlog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeBlog);
        }

        // GET: Control/HomeBlogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeBlog = await _context.HomeBlog.FindAsync(id);
            if (homeBlog == null)
            {
                return NotFound();
            }
            return View(homeBlog);
        }

        // POST: Control/HomeBlogs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content")] HomeBlog homeBlog)
        {
            if (id != homeBlog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(homeBlog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeBlogExists(homeBlog.Id))
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
            return View(homeBlog);
        }

        // GET: Control/HomeBlogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeBlog = await _context.HomeBlog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeBlog == null)
            {
                return NotFound();
            }

            return View(homeBlog);
        }

        // POST: Control/HomeBlogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeBlog = await _context.HomeBlog.FindAsync(id);
            _context.HomeBlog.Remove(homeBlog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeBlogExists(int id)
        {
            return _context.HomeBlog.Any(e => e.Id == id);
        }
    }
}
