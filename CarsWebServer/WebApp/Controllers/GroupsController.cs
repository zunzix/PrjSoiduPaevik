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
public class GroupsController : Controller
{
    private readonly IAppUOW _uow;
    
    public GroupsController(IAppUOW uow)
    {
        _uow = uow;
    }
    
// GET: Groups
    public async Task<IActionResult> Index()
    {
        var res = await _uow.GroupRepository.AllAsync(User.GetUserId());
        return View(res);
    }

    // GET: Groups/Details/5
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null)
        {
            return NotFound();
        }
        var entity = await _uow.GroupRepository.FindAsync(id.Value, User.GetUserId());
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
    public async Task<IActionResult> Create(Group @group)
    {
        if (ModelState.IsValid)
        {
            @group.Id = Guid.NewGuid();
            _uow.GroupRepository.Add(@group);

            var groupMember = new GroupMember
            {
                Id = Guid.NewGuid(),
                GroupId = @group.Id,
                UserId = User.GetUserId(),
                IsAdmin = true
            };
            
            _uow.GroupMemberRepository.Add(groupMember);
            
            await _uow.SaveChangesAsync();
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
        
        var entity = await _uow.GroupRepository.FindAsync(id.Value, User.GetUserId());
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
    public async Task<IActionResult> Edit(Guid id, Group @group)
    {
        
        if (id != @group.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _uow.GroupRepository.Update(@group);
            await _uow.SaveChangesAsync();
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

        var entity = await _uow.GroupRepository.FindAsync(id.Value, User.GetUserId());
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
        await _uow.GroupRepository.RemoveAsync(id);

        await _uow.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    
}