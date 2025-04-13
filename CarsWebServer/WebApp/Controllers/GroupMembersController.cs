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
// todo remove _context and figure out _context.Users
[Authorize]
public class GroupMembersController : Controller
{
    private readonly AppDbContext _context;
    private readonly GroupRepository _groupRepository;
    private readonly GroupMemberRepository _groupMemberRepository;

    public GroupMembersController(AppDbContext context, GroupMemberRepository groupMemberRepository, GroupRepository groupRepository)
    {
        _context = context;
        _groupMemberRepository = groupMemberRepository;
        _groupRepository = groupRepository;
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

        var entity = await _groupMemberRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: GroupMembers/Create
    public IActionResult Create()
    {
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name");
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
        if (ModelState.IsValid)
        {
            groupMember.Id = Guid.NewGuid();
            
            _groupMemberRepository.Add(groupMember);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", groupMember.UserId);
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name", groupMember.GroupId);
        return View(groupMember);
    }

    // GET: GroupMembers/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _groupMemberRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name");
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id");
        return View(entity);
    }

    // POST: GroupMembers/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, [Bind("GroupId,AppUserId,IsAdmin,Id")] GroupMember groupMember)
    {
        if (id != groupMember.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _groupMemberRepository.Update(groupMember);
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
        ViewData["AppUserId"] = new SelectList(_context.Users, "Id", "Id", groupMember.UserId);
        ViewData["GroupId"] = new SelectList(_groupRepository.AllAdmins(User.GetUserId()), "Id", "Name", groupMember.GroupId);
        return View(groupMember);
    }

    // GET: GroupMembers/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _groupMemberRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // POST: GroupMembers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _groupMemberRepository.RemoveAsync(id);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool GroupMemberExists(Guid id)
    {
        return _context.GroupMembers.Any(e => e.Id == id);
    }
}