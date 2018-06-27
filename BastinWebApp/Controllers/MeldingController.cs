using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BastinWebApp.Models;

namespace BastinWebApp.Controllers
{
    public class MeldingController : Controller
    {
        private readonly BastinWebAppContext _context;

        public MeldingController(BastinWebAppContext context)
        {
            _context = context;
        }

        // GET: Melding
        public async Task<IActionResult> Index()
        {
            return View(await _context.Melding.ToListAsync());
        }

        // GET: Melding/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melding = await _context.Melding
                .SingleOrDefaultAsync(m => m.ID == id);
            if (melding == null)
            {
                return NotFound();
            }

            return View(melding);
        }

        // GET: Melding/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Melding/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,TypeMelding,Datum,AgendaDatum,Titel,Ondertitel,Omschrijving,Afdeling,Machine,Klant,Link,AfbeeldingPad,ProcedurePad")] Melding melding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(melding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(melding);
        }

        // GET: Melding/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melding = await _context.Melding.SingleOrDefaultAsync(m => m.ID == id);
            if (melding == null)
            {
                return NotFound();
            }
            return View(melding);
        }

        // POST: Melding/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,TypeMelding,Datum,AgendaDatum,Titel,Ondertitel,Omschrijving,Afdeling,Machine,Klant,Link,AfbeeldingPad,ProcedurePad")] Melding melding)
        {
            if (id != melding.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(melding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeldingExists(melding.ID))
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
            return View(melding);
        }

        // GET: Melding/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var melding = await _context.Melding
                .SingleOrDefaultAsync(m => m.ID == id);
            if (melding == null)
            {
                return NotFound();
            }

            return View(melding);
        }

        // POST: Melding/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var melding = await _context.Melding.SingleOrDefaultAsync(m => m.ID == id);
            _context.Melding.Remove(melding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeldingExists(int id)
        {
            return _context.Melding.Any(e => e.ID == id);
        }
    }
}
