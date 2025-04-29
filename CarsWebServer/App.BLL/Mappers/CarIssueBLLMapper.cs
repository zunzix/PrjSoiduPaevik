using App.DAL.DTO;
using Base.BLL.Contracts;

namespace App.BLL.Mappers;

public class CarIssueBLLMapper : IBLLMapper<App.BLL.DTO.CarIssue, App.DAL.DTO.CarIssue>
{
    public CarIssue? Map(DTO.CarIssue? entity)
    {
        throw new NotImplementedException();
    }

    public DTO.CarIssue? Map(CarIssue? entity)
    {
        throw new NotImplementedException();
    }
}