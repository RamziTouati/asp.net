using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Protection_civile.Data;
using Protection_civile.Models;

namespace Protection_civile.Controllers
{
    public class RapportInitialsController : Controller
    {
        private readonly ProtectioncivileContext _context;

        public RapportInitialsController(ProtectioncivileContext context)
        {
            _context = context;
        }

        // GET: RapportInitials
        public async Task<IActionResult> Index()
        {
            var protectioncivileContext = _context.RapportInitial.Include(r => r.demande);
            return View(await protectioncivileContext.ToListAsync());
        }

        // GET: RapportInitials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapportInitial = await _context.RapportInitial
                .Include(r => r.demande)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rapportInitial == null)
            {
                return NotFound();
            }

            return View(rapportInitial);
        }

        // GET: RapportInitials/Create
        public IActionResult Create()
        {
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id");
            return View();
        }

        // POST: RapportInitials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateN,description,DemandeId")] RapportInitial rapportInitial)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rapportInitial);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportInitial.DemandeId);
            return View(rapportInitial);
        }

        // GET: RapportInitials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapportInitial = await _context.RapportInitial.FindAsync(id);
            if (rapportInitial == null)
            {
                return NotFound();
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportInitial.DemandeId);
            return View(rapportInitial);
        }

        // POST: RapportInitials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateN,description,DemandeId")] RapportInitial rapportInitial)
        {
            if (id != rapportInitial.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rapportInitial);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RapportInitialExists(rapportInitial.Id))
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
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportInitial.DemandeId);
            return View(rapportInitial);
        }

        // GET: RapportInitials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapportInitial = await _context.RapportInitial
                .Include(r => r.demande)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rapportInitial == null)
            {
                return NotFound();
            }

            return View(rapportInitial);
        }

        // POST: RapportInitials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rapportInitial = await _context.RapportInitial.FindAsync(id);
            _context.RapportInitial.Remove(rapportInitial);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapportInitialExists(int id)
        {
            return _context.RapportInitial.Any(e => e.Id == id);
        }
    }
}
