using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.Domain;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
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
        //Ask only data for current user
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        var res = await _context
            .CarLogs
            .Include(c => c.AppUser)
            .Include(c => c.Car)
            .ThenInclude(car => car!.Group)
            .Where(cl => cl.Car!.Group!.GroupMembers!
                .Any(gm => gm.AppUserId == userId))
            .ToListAsync();
        
        return View(res);
    }

    // GET: CarLogs/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var carLog = await _context.CarLogs
            .Include(c => c.AppUser)
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
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        // Get cars that belong to groups where the user is a member
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.AppUserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View();
    }

    // POST: CarLogs/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CarId,AppUserId,StartDate,EndDate,StartPoint,EndPoint,Distance,Comment,Id")] CarLog carLog)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        carLog.AppUserId = userId;
        
        if (ModelState.IsValid)
        {
            carLog.EndDate = DateTime.SpecifyKind(carLog.EndDate, DateTimeKind.Utc);
            carLog.StartDate = DateTime.SpecifyKind(carLog.StartDate, DateTimeKind.Utc);
                
            carLog.Id = Guid.NewGuid();
            _context.Add(carLog);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        // If model is invalid, repopulate the filtered car list
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.AppUserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carLog.CarId);
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
        
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        // Get cars that belong to groups where the user is a member
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.AppUserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View(carLog);
    }

    // POST: CarLogs/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("CarId,AppUserId,StartDate,EndDate,StartPoint,EndPoint,Distance,Comment,Id")] CarLog carLog)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
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
        // If model is invalid, repopulate the filtered car list
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.AppUserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carLog.CarId);
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
            .Include(c => c.AppUser)
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