using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.DAL.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using App.DAL.EF;
using App.Domain;
using Base.Helpers;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;

// todo : add user specific Find
// todo : remove _context

namespace WebApp.ApiControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GroupMembersController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAppUOW _uow;

        public GroupMembersController(AppDbContext context, IAppUOW uow)
        {
            _context = context;
            _uow = uow;
        }

        // GET: api/GroupMembers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GroupMember>>> GetGroupMembers()
        {
            var groupMembers = await _uow.GroupMemberRepository.AllAsync(User.GetUserId());
            return Ok(groupMembers.Select(c => new 
            {
                c.Id,
                c.Group!.Name,
                c.GroupId,
                c.UserId,
                c.User!.Email,
                c.IsAdmin
            }).ToList());
        }
        
        // GET: api/GroupMembers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupMember>> GetGroupGroupMembers(Guid id)
        {
            var groupMembers = await _uow.GroupMemberRepository.AllAsync(User.GetUserId());
            var groupGroupMembers = await _uow.GroupMemberRepository.AllGroupGroupMembersAsync(groupMembers, id);
            return Ok(groupGroupMembers.Select(c => new 
            {
                c.Id,
                c.Group!.Name,
                c.GroupId,
                c.UserId,
                c.User!.Email,
                c.IsAdmin
            }).ToList());
        }

        // GET: api/GroupMembers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GroupMember>> GetGroupMember(Guid id)
        {
            var entity = await _uow.GroupMemberRepository.FindAsync(id, User.GetUserId());
            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

        // PUT: api/GroupMembers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroupMember(Guid id, GroupMember groupMember)
        {
            if (id != groupMember.Id)
            {
                return BadRequest();
            }
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), groupMember.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _context.Entry(groupMember).State = EntityState.Modified;
            
            await _uow.SaveChangesAsync();

            return NoContent();
        }

        // POST: api/GroupMembers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GroupMember>> PostGroupMember(GroupMember groupMember)
        {
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), groupMember.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }
            
            _uow.GroupMemberRepository.Add(groupMember);
            await _uow.SaveChangesAsync();

            return CreatedAtAction("GetGroupMember", new { id = groupMember.Id }, groupMember);
        }

        // DELETE: api/GroupMembers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroupMember(Guid id)
        {
            var groupMember = await _uow.GroupMemberRepository.FindAsync(id);
            if (groupMember == null)
            {
                return NotFound();
            }
            
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), groupMember.GroupId);
            if (!isAdmin)
            {
                return Forbid();
            }

            _uow.GroupMemberRepository.Remove(groupMember);
            await _uow.SaveChangesAsync();

            return NoContent();
        }

    }
}
