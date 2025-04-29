using App.DAL.DTO;
using Base.BLL.Contracts;

namespace App.BLL.Mappers;

public class CarBLLMapper : IBLLMapper<App.BLL.DTO.Car, App.DAL.DTO.Car>
{
    public Car? Map(DTO.Car? entity)
    {
        throw new NotImplementedException();
    }

    public DTO.Car? Map(Car? entity)
    {
        throw new NotImplementedException();
    }
}