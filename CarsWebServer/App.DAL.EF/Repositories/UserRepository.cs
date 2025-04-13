using App.DAL.Contracts;
using App.Domain.Identity;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class UserRepository : BaseRepository<AppUser>, IUserRepository
{
    public UserRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}