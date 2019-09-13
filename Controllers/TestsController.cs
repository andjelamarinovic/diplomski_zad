
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportApp.Models;
using SportApp.Models.ViewModel;

namespace SportApp.Views
{
    public class TestsController : Controller
    {
        private readonly SportAppContext _context;

        public TestsController(SportAppContext context)
        {
            _context = context;
        }

        // GET: Tests
        public async Task<IActionResult> Index()
        {
            var sportAppContext = _context.Test.Include(t => t.Norma).Include(t => t.Testiranje).Include(t => t.VrstaTesta);
            return View(await sportAppContext.ToListAsync());
        }

        // GET: Tests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.Test
                .Include(t => t.Norma)
                .Include(t => t.Testiranje)
                .Include(t => t.VrstaTesta)
                .FirstOrDefaultAsync(m => m.TestId == id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        //GET: Tests/Create
        public IActionResult Create(int? id)
        {
            var vm = new TestiranjeViewModel();

            
            var vrsta = _context.VrstaTesta;
            var rezultati = _context.Test;



            vm = new TestiranjeViewModel()
            {
                TestsRezultati = vrsta.Select(x => new TestRezultat()
                {
                    VrstaTestaId = x.VrstaTestaId,
                    NazivTesta = x.NazivTesta
                    



                }).ToList()

            };
            vm.DatumTesta = DateTime.UtcNow;


            return View(vm);



            //var model_rez = new TestiranjeViewModel()
            //{
            //    TestsRezultati = vrsta.Select(x => new TestRezultat()
            //    {
            //        VrstaTestaId = x.VrstaTestaId,
            //        NazivTesta = x.NazivTesta
            //    }).ToList()
            //};


            //vm.TestsRezultati = _context.VrstaTesta
            //    .Join(
            //        _context.Test,
            //        t => t.VrstaTestaId,
            //        vt => vt.VrstaTestaId,
            //        (t, vt) => new TestRezultat { VrstaTestaId = t.VrstaTestaId, NazivTesta = t.NazivTesta, Rezultat = vt.TestRezultat }).ToList();



        }

        //POST: Tests/Create
        //To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id, List<TestRezultat> testRezultats)
        {
            if (ModelState.IsValid)
            {
                Test test = new Test();
                test.TestiranjeId = id;
                test.NormaId = 17;
                foreach (var item in testRezultats)
                {
                    test.VrstaTestaId = item.VrstaTestaId;
                    test.TestRezultat = item.Rezultat;
                }
                test.Ocjena = 5;
                _context.SaveChanges();
                _context.Add(test);
            }
            return RedirectToAction(nameof(Index));
        }
            // GET: Tests/Edit/5
            public async Task<IActionResult> Edit(int? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                var test = await _context.Test.FindAsync(id);
                if (test == null)
                {
                    return NotFound();
                }
                ViewData["NormaId"] = new SelectList(_context.Norma, "NormaId", "NormaId", test.NormaId);
                ViewData["TestiranjeId"] = new SelectList(_context.Testiranje, "TestiranjeId", "TestiranjeId", test.TestiranjeId);
                ViewData["VrstaTestaId"] = new SelectList(_context.VrstaTesta, "VrstaTestaId", "VrstaTestaId", test.VrstaTestaId);
                return View(test);
            }

        // POST: Tests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TestId,VrstaTestaId,TestiranjeId,NormaId,TestRezultat,Ocjena")] Test test)
        {
            if (id != test.TestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(test);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestExists(test.TestId))
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
            ViewData["NormaId"] = new SelectList(_context.Norma, "NormaId", "NormaId", test.NormaId);
            ViewData["TestiranjeId"] = new SelectList(_context.Testiranje, "TestiranjeId", "TestiranjeId", test.TestiranjeId);
            ViewData["VrstaTestaId"] = new SelectList(_context.VrstaTesta, "VrstaTestaId", "VrstaTestaId", test.VrstaTestaId);
            return View(test);
        }

        // GET: Tests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var test = await _context.Test
                .Include(t => t.Norma)
                .Include(t => t.Testiranje)
                .Include(t => t.VrstaTesta)
                .FirstOrDefaultAsync(m => m.TestId == id);
            if (test == null)
            {
                return NotFound();
            }

            return View(test);
        }

        // POST: Tests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var test = await _context.Test.FindAsync(id);
            _context.Test.Remove(test);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestExists(int id)
        {
            return _context.Test.Any(e => e.TestId == id);
        }
    }
}


