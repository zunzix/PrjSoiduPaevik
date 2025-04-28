using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarInsuranceMapper : IMapper<App.DAL.DTO.CarInsurance, App.Domain.CarInsurance>
{
    public CarInsurance? Map(Domain.CarInsurance? entity)
    {
        if (entity == null) return null;
        
        var res = new CarInsurance()
        {
            Id = entity.Id,

            CarId = entity.CarId,
            //todo : add mapping
            Car = null,

            Name = entity.Name,
            EndDate = entity.EndDate
        };
        return res;
    }

    public Domain.CarInsurance? Map(CarInsurance? entity)
    {
        if (entity == null) return null;
        
        var res = new Domain.CarInsurance()
        {
            Id = entity.Id,

            CarId = entity.CarId,
            //todo : add mapping
            Car = null,

            Name = entity.Name,
            EndDate = entity.EndDate
        };
        return res;
    }
}