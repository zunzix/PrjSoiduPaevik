using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.DAL.EF.Repositories;
using App.Domain;
using Base.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
public class GroupMembersController : Controller
{
    private readonly AppDbContext _context;
    private readonly GroupMemberRepository _groupMemberRepository;

    public GroupMembersController(AppDbContext context, GroupMemberRepository groupMemberRepository)
    {
        _context = context;
        _groupMemberRepository = groupMemberRepository;
    }

    // GET: GroupMembers
    public async Task<IActionResult> Index()
    {
        var res = await _groupMemberRepository.AllAsync(User.GetUserId());
        return View(res);
    }

    // GET: GroupMembers/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var groupMember = await _context.GroupMembers
            .Include(g => g.User)
            .Include(g => g.Group)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (groupMember == null)
        {
            return NotFound();
        }

        return View(groupMember);
    }

    // GET: GroupMembers/Create
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
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
        return View();
    }

    // POST: GroupMembers/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(GroupMember groupMember)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        
        if (ModelState.IsValid)
        {
            groupMember.Id = Guid.NewGuid();
            
            _context.Add(groupMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        
        // Repopulate dropdowns if model is invalid
        var adminGroups = _context.GroupMembers
            .Where(gm => gm.UserId == userId && gm.IsAdmin)
            .Select(gm => gm.Group)
            .ToList();
        
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", groupMember.UserId);
        ViewData["GroupId"] = new SelectList(adminGroups, "Id", "Name", groupMember.GroupId);
        return View(groupMember);
    }

    // GET: GroupMembers/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var groupMember = await _context.GroupMembers.FindAsync(id);
        if (groupMember == null)
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
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
        return View(groupMember);
    }

    // POST: GroupMembers/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("GroupId,AppUserId,IsAdmin,Id")] GroupMember groupMember)
    {
        var userIdStr = User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value;
        var userId = Guid.Parse(userIdStr);
        
        if (id != groupMember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(groupMember);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupMemberExists(groupMember.Id))
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
        
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", groupMember.UserId);
        ViewData["GroupId"] = new SelectList(adminGroups, "Id", "Name", groupMember.GroupId);
        return View(groupMember);
    }

    // GET: GroupMembers/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var groupMember = await _context.GroupMembers
            .Include(g => g.User)
            .Include(g => g.Group)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (groupMember == null)
        {
            return NotFound();
        }

        return View(groupMember);
    }

    // POST: GroupMembers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var groupMember = await _context.GroupMembers.FindAsync(id);
        if (groupMember != null)
        {
            _context.GroupMembers.Remove(groupMember);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GroupMemberExists(Guid id)
    {
        return _context.GroupMembers.Any(e => e.Id == id);
    }
}