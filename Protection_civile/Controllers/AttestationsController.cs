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
    public class AttestationsController : Controller
    {
        private readonly ProtectioncivileContext _context;

        public AttestationsController(ProtectioncivileContext context)
        {
            _context = context;
        }

        // GET: Attestations
        public async Task<IActionResult> Index()
        {
            var protectioncivileContext = _context.Attestation.Include(a => a.demande);
            return View(await protectioncivileContext.ToListAsync());
        }

        // GET: Attestations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attestation = await _context.Attestation
                .Include(a => a.demande)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attestation == null)
            {
                return NotFound();
            }

            return View(attestation);
        }

        // GET: Attestations/Create
        public async Task<IActionResult> Create(int? id)
        {
            var DataDemande = await _context.Demande.FindAsync(id);
            if (DataDemande.Id == id)
            {
                ViewBag.id = id;
                ViewBag.nom = DataDemande.nom;
                ViewBag.prenom = DataDemande.prenom;
                ViewBag.tel = DataDemande.tel;
                ViewBag.numrecu = DataDemande.numrecu;
            }
            else
            {
                return NotFound();
            }

            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id");
            return View();
        }

        // POST: Attestations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DateN,DemandeId")] Attestation attestation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attestation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", attestation.DemandeId);
            return View(attestation);
        }

        public async Task<IActionResult> Creater([Bind("Id,DateN,DemandeId")] Attestation attestation)
        {

            if (ModelState.IsValid)
            {
                _context.Add(attestation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", attestation.DemandeId);
            return View(attestation);
        }

        // GET: Attestations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attestation = await _context.Attestation.FindAsync(id);
            if (attestation == null)
            {
                return NotFound();
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", attestation.DemandeId);
            return View(attestation);
        }

        // POST: Attestations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateN,DemandeId")] Attestation attestation)
        {
            if (id != attestation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attestation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttestationExists(attestation.Id))
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
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", attestation.DemandeId);
            return View(attestation);
        }

        // GET: Attestations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attestation = await _context.Attestation
                .Include(a => a.demande)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (attestation == null)
            {
                return NotFound();
            }

            return View(attestation);
        }

        // POST: Attestations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attestation = await _context.Attestation.FindAsync(id);
            _context.Attestation.Remove(attestation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttestationExists(int id)
        {
            return _context.Attestation.Any(e => e.Id == id);
        }
    }
}
