using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;


public class CarIssueRepository : BaseRepository<CarIssue>, ICarIssueRepository
{
    public CarIssueRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}