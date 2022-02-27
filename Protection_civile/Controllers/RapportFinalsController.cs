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
    public class RapportFinalsController : Controller
    {
        private readonly ProtectioncivileContext _context;

        public RapportFinalsController(ProtectioncivileContext context)
        {
            _context = context;
        }

        // GET: RapportFinals
        public async Task<IActionResult> Index()
        {
            var protectioncivileContext = _context.RapportFinal.Include(r => r.demande);
            return View(await protectioncivileContext.ToListAsync());
        }

        // GET: RapportFinals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapportFinal = await _context.RapportFinal
                .Include(r => r.demande)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rapportFinal == null)
            {
                return NotFound();
            }

            return View(rapportFinal);
        }

        // GET: RapportFinals/Create
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

        // POST: RapportFinals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,numrf,DateN,DemandeId")] RapportFinal rapportFinal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rapportFinal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportFinal.DemandeId);
            return View(rapportFinal);
        }
        public async Task<IActionResult> Creater([Bind("Id,numrf,DateN,DemandeId")] RapportFinal rapportFinal)
        {


            if (ModelState.IsValid)
            {
                _context.Add(rapportFinal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportFinal.DemandeId);
            return View(rapportFinal);
        }

        // GET: RapportFinals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapportFinal = await _context.RapportFinal.FindAsync(id);
            if (rapportFinal == null)
            {
                return NotFound();
            }
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportFinal.DemandeId);
            return View(rapportFinal);
        }

        // POST: RapportFinals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,numrf,DateN,DemandeId")] RapportFinal rapportFinal)
        {
            if (id != rapportFinal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rapportFinal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RapportFinalExists(rapportFinal.Id))
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
            ViewData["DemandeId"] = new SelectList(_context.Demande, "Id", "Id", rapportFinal.DemandeId);
            return View(rapportFinal);
        }

        // GET: RapportFinals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rapportFinal = await _context.RapportFinal
                .Include(r => r.demande)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rapportFinal == null)
            {
                return NotFound();
            }

            return View(rapportFinal);
        }

        // POST: RapportFinals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rapportFinal = await _context.RapportFinal.FindAsync(id);
            _context.RapportFinal.Remove(rapportFinal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RapportFinalExists(int id)
        {
            return _context.RapportFinal.Any(e => e.Id == id);
        }
    }
}
