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
    private readonly GroupRepository _groupRepository;
    private readonly GroupMemberRepository _groupMemberRepository;
    private readonly UserRepository _userRepository;

    public GroupMembersController(GroupMemberRepository groupMemberRepository, GroupRepository groupRepository, UserRepository userRepository)
    {
        _groupMemberRepository = groupMemberRepository;
        _groupRepository = groupRepository;
        _userRepository = userRepository;
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
        ViewData["AppUserId"] = new SelectList(_userRepository.All(), "Id", "Id");
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
            await _groupMemberRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        ViewData["AppUserId"] = new SelectList(await _userRepository.AllAsync(), "Id", "Id", groupMember.UserId);
        ViewData["GroupId"] = new SelectList(await _groupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name", groupMember.GroupId);
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

        ViewData["GroupId"] = new SelectList(await _groupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name");
        ViewData["AppUserId"] = new SelectList(await _userRepository.AllAsync(), "Id", "Id");
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
            _groupMemberRepository.Update(groupMember);
            await _groupMemberRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["AppUserId"] = new SelectList(await _userRepository.AllAsync(), "Id", "Id", groupMember.UserId);
        ViewData["GroupId"] = new SelectList(await _groupRepository.AllAdminsAsync(User.GetUserId()), "Id", "Name", groupMember.GroupId);
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
        await _groupMemberRepository.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

}