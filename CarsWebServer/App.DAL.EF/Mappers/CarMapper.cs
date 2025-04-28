using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarMapper : IMapper<App.DAL.DTO.Car, App.Domain.Car>
{
    private readonly AppDbContext _context;

    public CarMapper(AppDbContext context)
    {
        _context = context;
    }

    public Car? Map(Domain.Car? entity)
    {
        if (entity == null) return null;
        
        var res = new Car()
        {
            Id = entity.Id,

            GroupId = entity.GroupId,
            //todo : add mapping
            Group = null,

            Name = entity.Name,
            RegistrationPlate = entity.RegistrationPlate,
            Mileage = entity.Mileage,
            AvgFuelCons = entity.AvgFuelCons,
            IsAvailable = entity.IsAvailable,
            IsArchived = entity.IsArchived,
            IsCritical = entity.IsCritical,

            CarIssues = entity.CarIssues?.Select(ci => new CarIssue()
            {
                Id = ci.Id,

                CarId = ci.CarId,
                //todo : add mapping
                Car = null,

                Issue = ci.Issue,
                IsCritical = ci.IsCritical,
                IsResolved = ci.IsResolved
            }).ToList(),
            CarInsurances = entity.CarInsurances?.Select(ci => new CarInsurance()
            {
                Id = ci.Id,

                CarId = ci.CarId,
                //todo : add mapping
                Car = null,

                Name = ci.Name,
                EndDate = ci.EndDate
            }).ToList(),
            CarLogs = entity.CarLogs?.Select(ci =>
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == ci.UserId);
                if (user == null)
                {
                    return null;
                }
                
                return new CarLog()
                {
                    Id = ci.Id,

                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,

                    Email = user.Email!,
                    StartDate = ci.StartDate,
                    EndDate = ci.EndDate,
                    StartPoint = ci.StartPoint,
                    EndPoint = ci.EndPoint,
                    Distance = ci.Distance,
                    Comment = ci.Comment
                };
            }).ToList()!
        };
        return res;
    }

    public Domain.Car? Map(Car? entity)
    {
        if (entity == null) return null;



        var res = new Domain.Car()
        {
            Id = entity.Id,

            GroupId = entity.GroupId,
            //todo : add mapping
            Group = null,

            Name = entity.Name,
            RegistrationPlate = entity.RegistrationPlate,
            Mileage = entity.Mileage,
            AvgFuelCons = entity.AvgFuelCons,
            IsAvailable = entity.IsAvailable,
            IsArchived = entity.IsArchived,
            IsCritical = entity.IsCritical,

            CarIssues = entity.CarIssues?.Select(ci => new Domain.CarIssue()
            {
                Id = ci.Id,

                CarId = ci.CarId,
                //todo : add mapping
                Car = null,

                Issue = ci.Issue,
                IsCritical = ci.IsCritical,
                IsResolved = ci.IsResolved
            }).ToList(),
            CarInsurances = entity.CarInsurances?.Select(ci => new Domain.CarInsurance()
            {
                Id = ci.Id,

                CarId = ci.CarId,
                //todo : add mapping
                Car = null,

                Name = ci.Name,
                EndDate = ci.EndDate
            }).ToList(),
            CarLogs = entity.CarLogs?.Select(ci =>
            {
                var normalizedEmail = ci.Email!.Normalize().ToUpperInvariant();

                var user = _context.Users.FirstOrDefault(u => u.NormalizedEmail == normalizedEmail);

                return new Domain.CarLog()
                {
                    Id = ci.Id,

                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,

                    UserId = user!.Id,
                    //todo : add mapping
                    User = null,

                    StartDate = ci.StartDate,
                    EndDate = ci.EndDate,
                    StartPoint = ci.StartPoint,
                    EndPoint = ci.EndPoint,
                    Distance = ci.Distance,
                    Comment = ci.Comment
                };
            }).ToList()
        };
        return res;
    }
}