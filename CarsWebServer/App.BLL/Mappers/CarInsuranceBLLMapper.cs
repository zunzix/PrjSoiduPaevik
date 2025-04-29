using App.DAL.DTO;
using Base.BLL.Contracts;

namespace App.BLL.Mappers;

public class CarInsuranceBLLMapper : IBLLMapper<App.BLL.DTO.CarInsurance, App.DAL.DTO.CarInsurance>
{
    public CarInsurance? Map(DTO.CarInsurance? entity)
    {
        throw new NotImplementedException();
    }

    public DTO.CarInsurance? Map(CarInsurance? entity)
    {
        throw new NotImplementedException();
    }
}