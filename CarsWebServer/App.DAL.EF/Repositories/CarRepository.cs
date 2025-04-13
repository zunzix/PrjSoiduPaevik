using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;

public class CarRepository : BaseRepository<Car>, ICarRepository
{
    public CarRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}