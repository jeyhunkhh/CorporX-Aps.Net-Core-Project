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
    public class TeamItemsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IFileManager _fileManager;

        public TeamItemsController(ApplicationDbContext context,
                                   IFileManager fileManager)
        {
            _context = context;
            _fileManager = fileManager;
        }

        // GET: Control/TeamItems
        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamItems.ToListAsync());
        }

        // GET: Control/TeamItems/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamItem = await _context.TeamItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamItem == null)
            {
                return NotFound();
            }

            return View(teamItem);
        }

        // GET: Control/TeamItems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Control/TeamItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FullName,Position,Content,Upload,Facebook,Linkedin,Dribbble")] TeamItem teamItem)
        {
            if (teamItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                var fileName = _fileManager.Upload(teamItem.Upload);
                teamItem.Photo = fileName;
                _context.Add(teamItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamItem);
        }

        // GET: Control/TeamItems/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamItem = await _context.TeamItems.FindAsync(id);
            if (teamItem == null)
            {
                return NotFound();
            }
            return View(teamItem);
        }

        // POST: Control/TeamItems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,Position,Content,Photo,Upload,Facebook,Linkedin,Dribbble")] TeamItem teamItem)
        {
            if (id != teamItem.Id)
            {
                return NotFound();
            }

            if (teamItem.Upload == null)
            {
                ModelState.AddModelError("Upload", "The Photo field is required.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var oldFile = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", teamItem.Photo);
                    _fileManager.Delete(oldFile);
                    var fileName = _fileManager.Upload(teamItem.Upload);
                    teamItem.Photo = fileName;
                    _context.Update(teamItem);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TeamItemExists(teamItem.Id))
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
            return View(teamItem);
        }

        // GET: Control/TeamItems/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teamItem = await _context.TeamItems
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teamItem == null)
            {
                return NotFound();
            }

            return View(teamItem);
        }

        // POST: Control/TeamItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var teamItem = await _context.TeamItems.FindAsync(id);
            try
            {
                _fileManager.Delete(teamItem.Photo);
            }
            catch (FileNotFoundException)
            {
                _context.TeamItems.Remove(teamItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            _context.TeamItems.Remove(teamItem);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TeamItemExists(int id)
        {
            return _context.TeamItems.Any(e => e.Id == id);
        }
    }
}
