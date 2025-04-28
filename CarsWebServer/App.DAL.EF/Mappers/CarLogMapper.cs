using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarLogMapper : IMapper<App.DAL.DTO.CarLog, App.Domain.CarLog>
{
    public CarLog? Map(Domain.CarLog? entity)
    {
        throw new NotImplementedException();
    }

    public Domain.CarLog? Map(CarLog? entity)
    {
        throw new NotImplementedException();
    }
}