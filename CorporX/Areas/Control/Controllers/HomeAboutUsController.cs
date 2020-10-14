using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CorporX.Data;
using CorporX.Models.Home;
using CorporX.Helpers;
using System.IO;
using CorporX.Filters;

namespace CorporX.Areas.Control.Controllers
{
    [TypeFilter(typeof(Auth))]
    [Area("Control")]
    public class HomeAboutUsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HomeAboutUsController(ApplicationDbContext context,
                                     IFileManager fileManager )
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Control/HomeAboutUs
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeAboutUs.ToListAsync());
        }

        // GET: Control/HomeAboutUs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeAboutUs = await _context.HomeAboutUs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeAboutUs == null)
            {
                return NotFound();
            }

            return View(homeAboutUs);
        }

        // GET: Control/HomeAboutUs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeAboutUs/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Text,Photo,Upload,Id,Title,Content")] HomeAboutUs homeAboutUs)
        {
            if (homeAboutUs.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(homeAboutUs.Upload);
                homeAboutUs.Photo = fileName;
                _context.Add(homeAboutUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeAboutUs);
        }

        // GET: Control/HomeAboutUs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeAboutUs = await _context.HomeAboutUs.FindAsync(id);
            if (homeAboutUs == null)
            {
                return NotFound();
            }
            return View(homeAboutUs);
        }

        // POST: Control/HomeAboutUs/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Text,Photo,Upload,Id,Title,Content")] HomeAboutUs homeAboutUs)
        {
            if (id != homeAboutUs.Id)
            {
                return NotFound();
            }

            if (homeAboutUs.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", homeAboutUs.Photo);
                    _fileManager.Delete(oldFile);
                    var fileName = _fileManager.Upload(homeAboutUs.Upload);
                    homeAboutUs.Photo = fileName;

                    _context.Update(homeAboutUs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeAboutUsExists(homeAboutUs.Id))
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
            return View(homeAboutUs);
        }

        // GET: Control/HomeAboutUs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeAboutUs = await _context.HomeAboutUs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeAboutUs == null)
            {
                return NotFound();
            }

            return View(homeAboutUs);
        }

        // POST: Control/HomeAboutUs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeAboutUs = await _context.HomeAboutUs.FindAsync(id);
            try
            {
                _fileManager.Delete(homeAboutUs.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.HomeAboutUs.Remove(homeAboutUs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.HomeAboutUs.Remove(homeAboutUs);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeAboutUsExists(int id)
        {
            return _context.HomeAboutUs.Any(e => e.Id == id);
        }
    }
}
