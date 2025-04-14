using App.Domain.Identity;
using Base.DAL.Contracts;
using Microsoft.AspNetCore.Identity;

namespace App.DAL.Contracts;


public interface IUserRepository : IBaseRepository<AppUser>
{
    
}