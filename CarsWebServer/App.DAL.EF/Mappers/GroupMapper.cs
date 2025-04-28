using App.DAL.DTO;
using App.Domain.Identity;
using Base.DAL.Contracts;
using Microsoft.AspNetCore.Identity;

namespace App.DAL.EF.Mappers;

public class GroupMapper : IMapper<App.DAL.DTO.Group, App.Domain.Group>
{
    private readonly AppDbContext _context;

    public GroupMapper(AppDbContext context)
    {
        _context = context;
    }

    public Group? Map(Domain.Group? entity)
    {
        if (entity == null) return null;
        
        var res = new Group()
        {
            Id = entity.Id,
            Name = entity.Name,
            GroupMembers = entity.GroupMembers?.Select(c =>
            {
                var user = _context.Users.FirstOrDefault(u => u.Id == c.UserId);
                if (user == null)
                {
                    return null;
                }

                
                return new GroupMember()
                {
                    Id = c.Id,

                    GroupId = c.GroupId,
                    //todo : add mapping
                    Group = null,

                    Email = user.Email!,

                    IsAdmin = c.IsAdmin
                };
            }).ToList()!,
            Cars = entity.Cars?.Select(c => new Car()
            {
                Id = c.Id,
                
                GroupId = c.GroupId,
                //todo : add mapping
                Group = null,
                
                Name = c.Name,
                RegistrationPlate = c.RegistrationPlate,
                Mileage = c.Mileage,
                AvgFuelCons = c.AvgFuelCons,
                IsAvailable = c.IsAvailable,
                IsArchived = c.IsArchived,
                IsCritical = c.IsCritical,
                
                CarIssues = c.CarIssues?.Select(ci => new CarIssue()
                {
                    Id = ci.Id,
                    
                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,
                    
                    Issue = ci.Issue,
                    IsCritical = ci.IsCritical,
                    IsResolved = ci.IsResolved
                }).ToList(),
                CarInsurances = c.CarInsurances?.Select(ci => new CarInsurance()
                { 
                    Id = ci.Id,
                    
                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,
                    
                    Name = ci.Name,
                    EndDate = ci.EndDate
                }).ToList(),
                CarLogs = c.CarLogs?.Select(ci =>
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

                        Email =  user.Email!,
                        StartDate = ci.StartDate,
                        EndDate = ci.EndDate,
                        StartPoint = ci.StartPoint,
                        EndPoint = ci.EndPoint,
                        Distance = ci.Distance,
                        Comment = ci.Comment
                    };
                }).ToList()!
            }).ToList()
        };
        return res;

    }

    public Domain.Group? Map(Group? entity)
    {
        if (entity == null) return null;
        
        
        
        var res = new Domain.Group()
        {
            Id = entity.Id,
            Name = entity.Name,
            GroupMembers = entity.GroupMembers?.Select(c =>
            {
                var normalizedEmail =  c.Email.Normalize().ToUpperInvariant();
                
                var user = _context.Users.FirstOrDefault(u => u.NormalizedEmail == normalizedEmail);

                return new Domain.GroupMember()
                {
                    Id = c.Id,

                    GroupId = c.GroupId,
                    //todo : add mapping
                    Group = null,

                    UserId = user!.Id,
                    //todo : add mapping
                    User = null,
                    
                    IsAdmin = c.IsAdmin
                };
            }).ToList(),
            Cars = entity.Cars?.Select(c => new Domain.Car()
            {
                Id = c.Id,
                
                GroupId = c.GroupId,
                //todo : add mapping
                Group = null,
                
                Name = c.Name,
                RegistrationPlate = c.RegistrationPlate,
                Mileage = c.Mileage,
                AvgFuelCons = c.AvgFuelCons,
                IsAvailable = c.IsAvailable,
                IsArchived = c.IsArchived,
                IsCritical = c.IsCritical,
                
                CarIssues = c.CarIssues?.Select(ci => new Domain.CarIssue()
                {
                    Id = ci.Id,
                    
                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,
                    
                    Issue = ci.Issue,
                    IsCritical = ci.IsCritical,
                    IsResolved = ci.IsResolved
                }).ToList(),
                CarInsurances = c.CarInsurances?.Select(ci => new Domain.CarInsurance()
                { 
                    Id = ci.Id,
                    
                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,
                    
                    Name = ci.Name,
                    EndDate = ci.EndDate
                }).ToList(),
                CarLogs = c.CarLogs?.Select(ci =>
                {
                    var normalizedEmail =  ci.Email!.Normalize().ToUpperInvariant();
                    
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
            }).ToList()
        };
        return res;
    }
}