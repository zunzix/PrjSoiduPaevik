using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarMapper : IMapper<App.DAL.DTO.Car, App.Domain.Car>
{
    public Car? Map(Domain.Car? entity)
    {
        throw new NotImplementedException();
    }

    public Domain.Car? Map(Car? entity)
    {
        throw new NotImplementedException();
    }
}