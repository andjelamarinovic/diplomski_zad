using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportApp.Models;

namespace SportApp.Views
{
    public class TestiranjesController : Controller
    {
        private readonly SportAppContext _context;

        public TestiranjesController(SportAppContext context)
        {
            _context = context;
        }

        // GET: Testiranjes
        public async Task<IActionResult> Index()
        {
            var sportAppContext = _context.Testiranje.Include(t => t.Razred).Include(t => t.Student);
            return View(await sportAppContext.ToListAsync());
        }

        // GET: Testiranjes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testiranje = await _context.Testiranje
                .Include(t => t.Razred)
                .Include(t => t.Student)
                .FirstOrDefaultAsync(m => m.TestiranjeId == id);
            if (testiranje == null)
            {
                return NotFound();
            }

            return View(testiranje);
        }

        // GET: Testiranjes/Create
        public IActionResult Create(int? id)
        {
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred");

            ViewData["Student_Ime"] = _context.Student
                    .Where(c => c.StudentId == id)
                    .Select(c => c.Ime)
                    .FirstOrDefault();
            ViewData["Student_Prezime"] = _context.Student
                    .Where(c => c.StudentId == id)
                    .Select(c => c.Prezime)
                    .FirstOrDefault();

            //ViewData["StudentId"] = new SelectList(valueSelected);

            return View();
        }

        // POST: Testiranjes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, [Bind("TestiranjeId,StudentId,RazredId,DatumTest")] Testiranje testiranje)
        {
            if (ModelState.IsValid)
            {
                var br = _context.Student
                   .Where(c => c.StudentId == id)
                   .Select(c => c.StudentId)
                   .FirstOrDefault();
                testiranje.StudentId = br;
                _context.Add(testiranje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred", testiranje.RazredId);
           

            //ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "Ime", testiranje.StudentId);
            //ViewData["StudentId_Ime"] = _context.Student
            //       .Where(c => c.StudentId == id)
            //       .Select(c => c.Ime)
            //       .FirstOrDefault();
            //ViewData["StudentId_Prezime"] = _context.Student
            //        .Where(c => c.StudentId == id)
            //        .Select(c => c.Prezime)
            //        .FirstOrDefault();

            return View(testiranje);
        }

        // GET: Testiranjes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testiranje = await _context.Testiranje.FindAsync(id);
            if (testiranje == null)
            {
                return NotFound();
            }
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred", testiranje.RazredId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "Ime", testiranje.StudentId);
            return View(testiranje);
        }

        // POST: Testiranjes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TestiranjeId,StudentId,RazredId,DatumTest")] Testiranje testiranje)
        {
            if (id != testiranje.TestiranjeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testiranje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestiranjeExists(testiranje.TestiranjeId))
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
            ViewData["RazredId"] = new SelectList(_context.Razred, "RazredId", "BrojRazred", testiranje.RazredId);
            ViewData["StudentId"] = new SelectList(_context.Student, "StudentId", "Ime", testiranje.StudentId);
            return View(testiranje);
        }

        // GET: Testiranjes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testiranje = await _context.Testiranje
                .Include(t => t.Razred)
                .Include(t => t.Student)
                .FirstOrDefaultAsync(m => m.TestiranjeId == id);
            if (testiranje == null)
            {
                return NotFound();
            }

            return View(testiranje);
        }

        // POST: Testiranjes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testiranje = await _context.Testiranje.FindAsync(id);
            _context.Testiranje.Remove(testiranje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestiranjeExists(int id)
        {
            return _context.Testiranje.Any(e => e.TestiranjeId == id);
        }
    }
}
