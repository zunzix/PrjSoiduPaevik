using App.DAL.DTO;
using Base.DAL.Contracts;

namespace App.DAL.EF.Mappers;

public class CarIssueMapper : IMapper<App.DAL.DTO.CarIssue, App.Domain.CarIssue>
{
    public CarIssue? Map(Domain.CarIssue? entity)
    {
        throw new NotImplementedException();
    }

    public Domain.CarIssue? Map(CarIssue? entity)
    {
        throw new NotImplementedException();
    }
}