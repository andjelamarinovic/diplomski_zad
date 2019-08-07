using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportApp.Models;

namespace SportApp.Controllers
{
    public class NormasController : Controller
    {
        private readonly SportAppContext _context;

        public NormasController(SportAppContext context)
        {
            _context = context;
        }

        // GET: Normas
        public async Task<IActionResult> Index()
        {
            var sportAppContext = _context.Norma.Include(n => n.Razred).Include(n => n.Spol).Include(n => n.VrstaTesta);
            return View(await sportAppContext.ToListAsync());
        }

        // GET: Normas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var norma = await _context.Norma
                .Include(n => n.Razred)
                .Include(n => n.Spol)
                .Include(n => n.VrstaTesta)
                .FirstOrDefaultAsync(m => m.NormaId == id);
            if (norma == null)
            {
                return NotFound();
            }

            return View(norma);
        }

        // GET: Normas/Create
        public IActionResult Create()
        {
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred");
            ViewData["SpolId"] = new SelectList(_context.Spol, "SpolId", "NazivSpola");
            ViewData["VrstaTestaId"] = new SelectList(_context.VrstaTesta, "VrstaTestaId", "NazivTesta");
            return View();
        }

        // POST: Normas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NormaId,VrstaTestaId,SpolId,RazredId,Ocjena1,Ocjena2,Ocjena3,Ocjena4,Ocjena5")] Norma norma)
        {
            if (ModelState.IsValid)
            {
                _context.Add(norma);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred", norma.RazredId);
            ViewData["SpolId"] = new SelectList(_context.Spol, "SpolId", "NazivSpola", norma.SpolId);
            ViewData["VrstaTestaId"] = new SelectList(_context.VrstaTesta, "VrstaTestaId", "NazivTesta", norma.VrstaTestaId);
            return View(norma);
        }

        // GET: Normas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var norma = await _context.Norma.FindAsync(id);
            if (norma == null)
            {
                return NotFound();
            }
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred", norma.RazredId);
            ViewData["SpolId"] = new SelectList(_context.Spol, "SpolId", "NazivSpola", norma.SpolId);
            ViewData["VrstaTestaId"] = new SelectList(_context.VrstaTesta, "VrstaTestaId", "NazivTesta", norma.VrstaTestaId);
            return View(norma);
        }

        // POST: Normas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NormaId,VrstaTestaId,SpolId,RazredId,Ocjena1,Ocjena2,Ocjena3,Ocjena4,Ocjena5")] Norma norma)
        {
            if (id != norma.NormaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(norma);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NormaExists(norma.NormaId))
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
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred", norma.RazredId);
            ViewData["SpolId"] = new SelectList(_context.Spol, "SpolId", "NazivSpola", norma.SpolId);
            ViewData["VrstaTestaId"] = new SelectList(_context.VrstaTesta, "VrstaTestaId", "NazivTesta", norma.VrstaTestaId);
            return View(norma);
        }

        // GET: Normas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var norma = await _context.Norma
                .Include(n => n.Razred)
                .Include(n => n.Spol)
                .Include(n => n.VrstaTesta)
                .FirstOrDefaultAsync(m => m.NormaId == id);
            if (norma == null)
            {
                return NotFound();
            }

            return View(norma);
        }

        // POST: Normas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var norma = await _context.Norma.FindAsync(id);
            _context.Norma.Remove(norma);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NormaExists(int id)
        {
            return _context.Norma.Any(e => e.NormaId == id);
        }
    }
}
