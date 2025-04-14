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
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class GroupsController : ControllerBase
    {
        private readonly IAppUOW _uow;
        private readonly AppDbContext _context;
    
        public GroupsController(IAppUOW uow, AppDbContext context)
        {
            _uow = uow;
            _context = context;
        }

        // GET: api/Groups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Group>>> GetGroups()
        {
            return (await _uow.GroupRepository.AllAsync(User.GetUserId())).ToList();
        }

        // GET: api/Groups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetGroup(Guid id)
        {
            var @group = await _uow.GroupRepository.FindAsync(id);

            if (@group == null)
            {
                return NotFound();
            }

            return @group;
        }

        // PUT: api/Groups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGroup(Guid id, Group @group)
        {
            if (id != @group.Id)
            {
                return BadRequest();
            }
            
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), @group.Id);
            if (!isAdmin)
            {
                return Forbid();
            }
            
            _context.Entry(@group).State = EntityState.Modified;
            await _uow.SaveChangesAsync();


            return NoContent();
        }

        // POST: api/Groups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Group>> PostGroup(Group @group)
        {
            _uow.GroupRepository.Add(@group);
            await _uow.SaveChangesAsync();
            
            var groupMember = new GroupMember
            {
                Id = Guid.NewGuid(),
                GroupId = @group.Id,
                UserId = User.GetUserId(),
                IsAdmin = true
            };
            
            _uow.GroupMemberRepository.Add(groupMember);

            return CreatedAtAction("GetGroup", new { id = @group.Id }, @group);
        }

        // DELETE: api/Groups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGroup(Guid id)
        {
            var entity = await _uow.GroupRepository.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            
            // Check if current user is admin of the group
            var isAdmin = await _uow.GroupRepository.IsUserAdminInGroup(User.GetUserId(), entity.Id);
            if (!isAdmin)
            {
                return Forbid();
            }

            _uow.GroupRepository.Remove(entity);
            await _uow.SaveChangesAsync();

            return NoContent();
        }
    }
}
