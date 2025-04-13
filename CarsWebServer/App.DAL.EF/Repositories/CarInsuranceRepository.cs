using App.DAL.Contracts;
using App.Domain;
using Base.DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace App.DAL.EF.Repositories;


public class CarInsuranceRepository : BaseRepository<CarInsurance>, ICarInsuranceRepository
{
    public CarInsuranceRepository(DbContext repositoryDbContext) : base(repositoryDbContext)
    {
    }
}