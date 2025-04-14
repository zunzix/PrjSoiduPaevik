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
using App.Domain;
using Base.Helpers;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Controllers;

[Authorize]
public class GroupMembersController : Controller
{
    private readonly IAppUOW _uow;
    
    public GroupMembersController(IAppUOW uow)
    {
        _uow = uow;
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
        ViewData["AppUserId"] = new SelectList(_uow.UserRepository.All(), "Id", "Email");
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
            
            _uow.GroupMemberRepository.Add(groupMember);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["AppUserId"] = new SelectList(await _uow.UserRepository.AllAsync(), "Id", "Email", groupMember.UserId);
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

        ViewData["GroupId"] = new SelectList(await _uow.GroupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name");
        ViewData["AppUserId"] = new SelectList(await _uow.UserRepository.AllAsync(), "Id", "Email");
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

        if (ModelState.IsValid)
        {
            _uow.GroupMemberRepository.Update(groupMember);
            await _uow.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["AppUserId"] = new SelectList(await _uow.UserRepository.AllAsync(), "Id", "Email", groupMember.UserId);
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

        return View(entity);
    }

    // POST: GroupMembers/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _uow.GroupMemberRepository.RemoveAsync(id);
        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}