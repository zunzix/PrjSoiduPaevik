using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class CarLogRepository : BaseRepository<CarLog>, ICarLogRepository
{
    public CarLogRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}