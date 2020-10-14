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
    public class HomeHeadersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public HomeHeadersController(ApplicationDbContext context,
                                     IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Control/HomeHeaders
        public async Task<IActionResult> Index()
        {
            return View(await _context.HomeHeader.ToListAsync());
        }

        // GET: Control/HomeHeaders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeHeader = await _context.HomeHeader
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeHeader == null)
            {
                return NotFound();
            }

            return View(homeHeader);
        }

        // GET: Control/HomeHeaders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/HomeHeaders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Heading,Upload,Id,Title,Content")] HomeHeader homeHeader)
        {
            if (homeHeader.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                var fileName =_fileManager.Upload(homeHeader.Upload);
                homeHeader.Photo = fileName;
                _context.Add(homeHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(homeHeader);
        }

        // GET: Control/HomeHeaders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeHeader = await _context.HomeHeader.FindAsync(id);
            if (homeHeader == null)
            {
                return NotFound();
            }
            return View(homeHeader);
        }

        // POST: Control/HomeHeaders/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Heading,Photo,Upload,Id,Title,Content")] HomeHeader homeHeader)
        {
            if (id != homeHeader.Id)
            {
                return NotFound();
            }

            if (homeHeader.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", homeHeader.Photo);
                    _fileManager.Delete(oldFile);
                    var fileName = _fileManager.Upload(homeHeader.Upload);
                    homeHeader.Photo = fileName;
                    
                    _context.Update(homeHeader);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HomeHeaderExists(homeHeader.Id))
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
            return View(homeHeader);
        }

        // GET: Control/HomeHeaders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var homeHeader = await _context.HomeHeader
                .FirstOrDefaultAsync(m => m.Id == id);
            if (homeHeader == null)
            {
                return NotFound();
            }

            return View(homeHeader);
        }

        // POST: Control/HomeHeaders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var homeHeader = await _context.HomeHeader.FindAsync(id);
            try
            {
                _fileManager.Delete(homeHeader.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.HomeHeader.Remove(homeHeader);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.HomeHeader.Remove(homeHeader);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HomeHeaderExists(int id)
        {
            return _context.HomeHeader.Any(e => e.Id == id);
        }
    }
}
