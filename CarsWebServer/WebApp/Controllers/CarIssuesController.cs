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
public class CarIssuesController : Controller
{
    private readonly AppDbContext _context;

    public CarIssuesController(AppDbContext context)
    {
        _context = context;
    }

    // GET: CarIssues
    public async Task<IActionResult> Index()
    {
        //Ask only data for current user
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        var res = await _context
            .CarIssues
            .Include(c => c.Car)
            .ThenInclude(car => car!.Group)
            .Where(cl => cl.Car!.Group!.GroupMembers!
                .Any(gm => gm.UserId == userId))
            .ToListAsync();
        
        return View(res);
    }

    // GET: CarIssues/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var carIssue = await _context.CarIssues
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (carIssue == null)
        {
            return NotFound();
        }

        return View(carIssue);
    }

    // GET: CarIssues/Create
    public IActionResult Create()
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        // Get cars that belong to groups where the user is a member
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View();
    }

    // POST: CarIssues/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CarId,Issue,IsCritical,IsResolved,Id")] CarIssue carIssue)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (ModelState.IsValid)
        {
            carIssue.Id = Guid.NewGuid();
            _context.Add(carIssue);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // If model is invalid, repopulate the filtered car list
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carIssue.CarId);
        return View(carIssue);
    }

    // GET: CarIssues/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var carIssue = await _context.CarIssues.FindAsync(id);
        if (carIssue == null)
        {
            return NotFound();
        }
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        // Get cars that belong to groups where the user is a member
        var userCars = _context.Cars
            .Where(c => _context.GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name");
        return View(carIssue);
    }

    // POST: CarIssues/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("CarId,Issue,IsCritical,IsResolved,Id")] CarIssue carIssue)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (id != carIssue.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(carIssue);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarIssueExists(carIssue.Id))
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
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToList();

        ViewData["CarId"] = new SelectList(userCars, "Id", "Name", carIssue.CarId);
        return View(carIssue);
    }

    // GET: CarIssues/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var carIssue = await _context.CarIssues
            .Include(c => c.Car)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (carIssue == null)
        {
            return NotFound();
        }

        return View(carIssue);
    }

    // POST: CarIssues/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var carIssue = await _context.CarIssues.FindAsync(id);
        if (carIssue != null)
        {
            _context.CarIssues.Remove(carIssue);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CarIssueExists(Guid id)
    {
        return _context.CarIssues.Any(e => e.Id == id);
    }
}