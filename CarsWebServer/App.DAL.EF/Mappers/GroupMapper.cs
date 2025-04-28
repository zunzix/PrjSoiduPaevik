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
            GroupMembers = entity.GroupMembers?.Select(c => new GroupMember()
            {
                Id = c.Id,
                
                GroupId = c.GroupId,
                //todo : add mapping
                Group = null,
                
                Email = c.User!.Email!,
                
                IsAdmin = c.IsAdmin
            }).ToList(),
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
                CarLogs = c.CarLogs?.Select(ci => new CarLog()
                { 
                    Id = ci.Id,
                    
                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,
                    
                    Email = ci.User!.Email!,
                    StartDate = ci.StartDate,
                    EndDate = ci.EndDate,
                    StartPoint = ci.StartPoint,
                    EndPoint = ci.EndPoint,
                    Distance = ci.Distance,
                    Comment = ci.Comment
                }).ToList()
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
            GroupMembers = entity.GroupMembers?.Select(c => new Domain.GroupMember()
            {
                Id = c.Id,
                
                GroupId = c.GroupId,
                //todo : add mapping
                Group = null,
                
                User = _context.Users.FirstOrDefault(u => u.Email == c.Email),
                UserId = _context.Users.FirstOrDefault(u => u.Email == c.Email)!.Id,
                
                IsAdmin = c.IsAdmin
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
                CarLogs = c.CarLogs?.Select(ci => new Domain.CarLog()
                { 
                    Id = ci.Id,
                    
                    CarId = ci.CarId,
                    //todo : add mapping
                    Car = null,
                    
                    User = _context.Users.FirstOrDefault(u => u.Email == ci.Email),
                    UserId = _context.Users.FirstOrDefault(u => u.Email == ci.Email)!.Id,
                    
                    StartDate = ci.StartDate,
                    EndDate = ci.EndDate,
                    StartPoint = ci.StartPoint,
                    EndPoint = ci.EndPoint,
                    Distance = ci.Distance,
                    Comment = ci.Comment
                }).ToList()
            }).ToList()
        };
        return res;
    }
}