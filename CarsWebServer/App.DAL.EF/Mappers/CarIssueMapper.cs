using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarIssueMapper : IMapper<App.DAL.DTO.CarIssue, App.Domain.CarIssue>
{
    public CarIssue? Map(Domain.CarIssue? entity)
    {
        if (entity == null) return null;
        
        var res = new CarIssue()
        {
            Id = entity.Id,

            CarId = entity.CarId,
            //todo : add mapping
            Car = null,

            Issue = entity.Issue,
            IsCritical = entity.IsCritical,
            IsResolved = entity.IsResolved
        };
        return res;
    }

    public Domain.CarIssue? Map(CarIssue? entity)
    {
        if (entity == null) return null;



        var res = new Domain.CarIssue()
        {
            Id = entity.Id,

            CarId = entity.CarId,
            //todo : add mapping
            Car = null,

            Issue = entity.Issue,
            IsCritical = entity.IsCritical,
            IsResolved = entity.IsResolved
        };
        return res;
    }
}