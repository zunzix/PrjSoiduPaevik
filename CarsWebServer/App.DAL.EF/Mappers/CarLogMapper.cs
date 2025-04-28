using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarLogMapper : IMapper<App.DAL.DTO.CarLog, App.Domain.CarLog>
{
    private readonly AppDbContext _context;

    public CarLogMapper(AppDbContext context)
    {
        _context = context;
    }

    public CarLog? Map(Domain.CarLog? entity)
    {
        if (entity == null) return null;
        
        
        var user = _context.Users.FirstOrDefault(u => u.Id == entity.UserId);
        if (user == null)
        {
            return null;
        }
        
        var res = new CarLog()
        {
            Id = entity.Id,

            CarId = entity.CarId,
            //todo : add mapping
            Car = null,

            Email = user.Email,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            StartPoint = entity.StartPoint,
            EndPoint = entity.EndPoint,
            Distance = entity.Distance,
            Comment = entity.Comment
        };
        return res;
    }

    public Domain.CarLog? Map(CarLog? entity)
    {
        if (entity == null) return null;
        
        var normalizedEmail =  entity.Email!.Normalize().ToUpperInvariant();
        
        var user = _context.Users.FirstOrDefault(u => u.NormalizedEmail == normalizedEmail);
        if (user == null)
        {
            return null;
        }

        var res = new Domain.CarLog()
        {
            Id = entity.Id,

            CarId = entity.CarId,
            //todo : add mapping
            Car = null,

            UserId = user!.Id,
            //todo : add mapping
            User = null,

            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            StartPoint = entity.StartPoint,
            EndPoint = entity.EndPoint,
            Distance = entity.Distance,
            Comment = entity.Comment
        
        };
        return res;
    }
}