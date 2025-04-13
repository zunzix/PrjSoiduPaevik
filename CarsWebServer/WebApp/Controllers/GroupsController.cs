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

// todo remove _context
[Authorize]
public class GroupsController : Controller
{
    private readonly AppDbContext _context;
    private readonly GroupRepository _groupRepository;

    public GroupsController(AppDbContext context, GroupRepository groupRepository)
    {
        _context = context;
        _groupRepository = groupRepository;
    }

    // GET: Groups
    public async Task<IActionResult> Index()
    {
        var res = await _groupRepository.AllAsync(User.GetUserId());
        return View(res);
    }

    // GET: Groups/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var entity = await _groupRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: Groups/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Groups/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Name,Id")] Group @group)
    {
        if (ModelState.IsValid)
        {
            @group.Id = Guid.NewGuid();
            _groupRepository.Add(@group);

            var groupMember = new GroupMember
            {
                Id = Guid.NewGuid(),
                GroupId = @group.Id,
                UserId = User.GetUserId(),
                IsAdmin = true
            };
            
            // todo add groupmember repo
            _groupMemberRepository.Add(groupMember);
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(@group);
    }

    // GET: Groups/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        
        var entity = await _groupRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        return View(entity);
    }

    // POST: Groups/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("Name,Id")] Group @group)
    {
        
        if (id != @group.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _groupRepository.Update(@group);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GroupExists(@group.Id))
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
        return View(@group);
    }

    // GET: Groups/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _groupRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // POST: Groups/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _groupRepository.RemoveAsync(id);

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GroupExists(Guid id)
    {
        return _context.Groups.Any(e => e.Id == id);
    }
}