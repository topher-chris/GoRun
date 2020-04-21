using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GoRun.Data;
using GoRun.Models;

namespace GoRun.Controllers
{
    public class RunningSpotsController : Controller
    {
        private readonly GoRunContext _context;

        public RunningSpotsController(GoRunContext context)
        {
            _context = context;
        }

        // GET: RunningSpots
        public async Task<IActionResult> Index()
        {
            return View(await _context.RunningSpot.ToListAsync());
        }

        // GET: RunningSpots/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningSpot = await _context.RunningSpot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (runningSpot == null)
            {
                return NotFound();
            }

            return View(runningSpot);
        }

        // GET: RunningSpots/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RunningSpots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,LocationName,SubmissionDate,LocationType,Rate")] RunningSpot runningSpot)
        {
            if (ModelState.IsValid)
            {
                _context.Add(runningSpot);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(runningSpot);
        }

        // GET: RunningSpots/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningSpot = await _context.RunningSpot.FindAsync(id);
            if (runningSpot == null)
            {
                return NotFound();
            }
            return View(runningSpot);
        }

        // POST: RunningSpots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,LocationName,SubmissionDate,LocationType,Rate")] RunningSpot runningSpot)
        {
            if (id != runningSpot.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(runningSpot);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RunningSpotExists(runningSpot.Id))
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
            return View(runningSpot);
        }

        // GET: RunningSpots/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var runningSpot = await _context.RunningSpot
                .FirstOrDefaultAsync(m => m.Id == id);
            if (runningSpot == null)
            {
                return NotFound();
            }

            return View(runningSpot);
        }

        // POST: RunningSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var runningSpot = await _context.RunningSpot.FindAsync(id);
            _context.RunningSpot.Remove(runningSpot);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool RunningSpotExists(int id)
        {
            return _context.RunningSpot.Any(e => e.Id == id);
        }
    }
}
