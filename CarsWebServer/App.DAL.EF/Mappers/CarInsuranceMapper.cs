using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarInsuranceMapper : IMapper<App.DAL.DTO.CarInsurance, App.Domain.CarInsurance>
{
    public CarInsurance? Map(Domain.CarInsurance? entity)
    {
        throw new NotImplementedException();
    }

    public Domain.CarInsurance? Map(CarInsurance? entity)
    {
        throw new NotImplementedException();
    }
}