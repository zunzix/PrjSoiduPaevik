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
public class CarsController : Controller
{
    private readonly AppDbContext _context;

    public CarsController(AppDbContext context)
    {
        _context = context;
    }

    // GET: Cars
    public async Task<IActionResult> Index()
    {
        //Ask only data for current user
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        var res = await _context
            .Cars
            .Include(c => c.Group)
            .Where(c => _context
                .GroupMembers
                .Any(gm => gm.GroupId == c.GroupId && gm.UserId == userId))
            .ToListAsync();
        
        return View(res);
    }

    // GET: Cars/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars
            .Include(c => c.Group)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (car == null)
        {
            return NotFound();
        }

        return View(car);
    }

    // GET: Cars/Create
    public IActionResult Create()
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
    
        // Get only groups where current user is an admin
        var adminGroups = _context.GroupMembers
            .Where(gm => gm.UserId == userId && gm.IsAdmin)
            .Select(gm => gm.Group)
            .ToList();
        
        ViewData["GroupId"] = new SelectList(adminGroups, "Id", "Name");
        return View();
    }

    // POST: Cars/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("GroupId,Name,Mileage,AvgFuelCons,IsAvailable,IsArchived,Id")] Car car)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (ModelState.IsValid)
        {
            car.Id = Guid.NewGuid();
            _context.Add(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        // Repopulate dropdowns if model is invalid
        var adminGroups = _context.GroupMembers
            .Where(gm => gm.UserId == userId && gm.IsAdmin)
            .Select(gm => gm.Group)
            .ToList();
        
        ViewData["GroupId"] = new SelectList(adminGroups, "Id", "Name", car.GroupId);
        return View(car);
    }

    // GET: Cars/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars.FindAsync(id);
        if (car == null)
        {
            return NotFound();
        }
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
    
        // Get only groups where current user is an admin
        var adminGroups = _context.GroupMembers
            .Where(gm => gm.UserId == userId && gm.IsAdmin)
            .Select(gm => gm.Group)
            .ToList();
        
        ViewData["GroupId"] = new SelectList(adminGroups, "Id", "Name");
        return View(car);
    }

    // POST: Cars/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("GroupId,Name,Mileage,AvgFuelCons,IsAvailable,IsArchived,Id")] Car car)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (id != car.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(car);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(car.Id))
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
        // Repopulate dropdowns if model is invalid
        var adminGroups = _context.GroupMembers
            .Where(gm => gm.UserId == userId && gm.IsAdmin)
            .Select(gm => gm.Group)
            .ToList();
        
        ViewData["GroupId"] = new SelectList(adminGroups, "Id", "Name", car.GroupId);
        return View(car);
    }

    // GET: Cars/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars
            .Include(c => c.Group)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (car == null)
        {
            return NotFound();
        }

        return View(car);
    }

    // POST: Cars/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var car = await _context.Cars.FindAsync(id);
        if (car != null)
        {
            _context.Cars.Remove(car);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CarExists(Guid id)
    {
        return _context.Cars.Any(e => e.Id == id);
    }
}