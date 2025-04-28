using App.DAL.DTO;
using Base.BLL.Contracts;

namespace App.BLL.Mappers;

public class CarLogBLLMapper : IBLLMapper<App.BLL.DTO.CarLog, App.DAL.DTO.CarLog>
{
    public CarLog? Map(DTO.CarLog? entity)
    {
        throw new NotImplementedException();
    }

    public DTO.CarLog? Map(CarLog? entity)
    {
        throw new NotImplementedException();
    }
}