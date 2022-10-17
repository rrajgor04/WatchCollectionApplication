using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WatchCollectionApplication.Data;
using WatchCollectionApplication.Models;

namespace WatchCollectionApplication.Controllers
{
    public class WatchesController : Controller
    {
        private readonly WatchCollectionApplicationContext _context;

        public WatchesController(WatchCollectionApplicationContext context)
        {
            _context = context;
        }

        // GET: Watches
        public async Task<IActionResult> Index(string watchType, string searchString)
        {
            IQueryable<string> typeQuery = from w in _context.Watch
                                            orderby w.TypeOfWatch
                                           select w.TypeOfWatch;

            var watches = from w in _context.Watch
                         select w;

            if (!String.IsNullOrEmpty(searchString))
            {
                watches = watches.Where(s => s.BrandName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(watchType))
            {
                watches = watches.Where(x => x.TypeOfWatch == watchType);
            }

            var watchTypeVM = new WatchTypeViewModel
            {
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Watches = await watches.ToListAsync()
            };
            return View(watchTypeVM);
        }

        // GET: Watches/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watch = await _context.Watch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (watch == null)
            {
                return NotFound();
            }

            return View(watch);
        }

        // GET: Watches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Watches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BrandName,ReleaseDate,WatchMaterial,TypeOfWatch,Quality,Durability,Price,Rating")] Watch watch)
        {
            if (ModelState.IsValid)
            {
                _context.Add(watch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(watch);
        }

        // GET: Watches/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watch = await _context.Watch.FindAsync(id);
            if (watch == null)
            {
                return NotFound();
            }
            return View(watch);
        }

        // POST: Watches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BrandName,ReleaseDate,WatchMaterial,TypeOfWatch,Quality,Durability,Price,Rating")] Watch watch)
        {
            if (id != watch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(watch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WatchExists(watch.Id))
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
            return View(watch);
        }

        // GET: Watches/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var watch = await _context.Watch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (watch == null)
            {
                return NotFound();
            }

            return View(watch);
        }

        // POST: Watches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var watch = await _context.Watch.FindAsync(id);
            _context.Watch.Remove(watch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WatchExists(int id)
        {
            return _context.Watch.Any(e => e.Id == id);
        }
    }
}
