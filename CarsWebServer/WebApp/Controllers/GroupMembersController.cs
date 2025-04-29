using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using App.DAL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.DAL.EF.Repositories;
using App.DAL.DTO;
using Base.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
public class GroupMembersController : Controller
{
    private readonly IAppUOW _uow;
    private readonly AppDbContext _context;
    
    public GroupMembersController(IAppUOW uow, AppDbContext context)
    {
        _uow = uow;
        _context = context;
    }

    // GET: GroupMembers
    public async Task<IActionResult> Index()
    {
        var res = await _uow.GroupMemberRepository.AllAsync(User.GetUserId());
        return View(res);
    }

    // GET: GroupMembers/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.GroupMemberRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        return View(entity);
    }

    // GET: GroupMembers/Create
    public IActionResult Create()
    {
        ViewData["GroupId"] = new SelectList(_uow.GroupRepository.AllAdmins(User.GetUserId()), "Id", "Name");
        ViewData["AppUserId"] = new SelectList(_context.Users, "Email", "Email");
        return View();
    }

    // POST: GroupMembers/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(GroupMember groupMember)
    {
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), groupMember.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }

        
        if (ModelState.IsValid)
        {
            groupMember.Id = Guid.NewGuid();
            
            _uow.GroupMemberRepository.Add(groupMember);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["AppUserId"] = new SelectList(_context.Users, "Email", "Email", groupMember.Email);
        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name", groupMember.GroupId);
        return View(groupMember);
    }

    // GET: GroupMembers/Edit/5
    public async Task<IActionResult> Edit(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.GroupMemberRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }


        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name");
        ViewData["AppUserId"] = new SelectList(_context.Users, "Email", "Email");
        return View(entity);
    }

    // POST: GroupMembers/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Guid id, GroupMember groupMember)
    {
        if (id != groupMember.Id)
        {
            return NotFound();
        }
        
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), groupMember.GroupId);
        if (!isAdmin)
        {
            return Forbid(); 
        }

        if (ModelState.IsValid)
        {
            _uow.GroupMemberRepository.Update(groupMember);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["AppUserId"] = new SelectList(_context.Users, "Email", "Email", groupMember.Email);
        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name", groupMember.GroupId);
        return View(groupMember);
    }

    // GET: GroupMembers/Delete/5
    public async Task<IActionResult> Delete(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var entity = await _uow.GroupMemberRepository.FindAsync(id.Value, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }
        
        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }

        return View(entity);
    }

    // POST: GroupMembers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        var entity = await _uow.GroupMemberRepository.FindAsync(id, User.GetUserId());
        if (entity == null)
        {
            return NotFound();
        }

        // Check if current user is admin of the group
        var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.GroupId);
        if (!isAdmin)
        {
            return Forbid();
        }
        
        await _uow.GroupMemberRepository.RemoveAsync(id);
        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}