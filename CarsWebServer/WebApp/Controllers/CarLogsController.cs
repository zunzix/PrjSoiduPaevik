using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.Domain;
using WebApp.Data;

namespace WebApp.Controllers
{
    public class CarLogsController : Controller
    {
        private readonly AppDbContext _context;

        public CarLogsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: CarLogs
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.CarLogs.Include(c => c.Car);
            return View(await appDbContext.ToListAsync());
        }

        // GET: CarLogs/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carLog = await _context.CarLogs
                .Include(c => c.Car)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carLog == null)
            {
                return NotFound();
            }

            return View(carLog);
        }

        // GET: CarLogs/Create
        public IActionResult Create()
        {
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Name");
            return View();
        }

        // POST: CarLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CarId,AuthorId,StartDate,EndDate,StartPoint,EndPoint,Distance,Comment,Id")] CarLog carLog)
        {
            if (ModelState.IsValid)
            {
                carLog.Id = Guid.NewGuid();
                _context.Add(carLog);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Name", carLog.CarId);
            return View(carLog);
        }

        // GET: CarLogs/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carLog = await _context.CarLogs.FindAsync(id);
            if (carLog == null)
            {
                return NotFound();
            }
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Name", carLog.CarId);
            return View(carLog);
        }

        // POST: CarLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("CarId,AuthorId,StartDate,EndDate,StartPoint,EndPoint,Distance,Comment,Id")] CarLog carLog)
        {
            if (id != carLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarLogExists(carLog.Id))
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
            ViewData["CarId"] = new SelectList(_context.Cars, "Id", "Name", carLog.CarId);
            return View(carLog);
        }

        // GET: CarLogs/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carLog = await _context.CarLogs
                .Include(c => c.Car)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carLog == null)
            {
                return NotFound();
            }

            return View(carLog);
        }

        // POST: CarLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var carLog = await _context.CarLogs.FindAsync(id);
            if (carLog != null)
            {
                _context.CarLogs.Remove(carLog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarLogExists(Guid id)
        {
            return _context.CarLogs.Any(e => e.Id == id);
        }
    }
}
