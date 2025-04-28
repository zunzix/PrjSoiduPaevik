using App.BLL.Contracts;
using App.BLL.DTO;
using App.DAL.Contracts;
using Base.BLL;
using Base.BLL.Contracts;
using Base.DAL.Contracts;

namespace App.BLL.Services;

public class GroupService : BaseService<App.BLL.DTO.Group, App.DAL.DTO.Group, App.DAL.Contracts.IGroupRepository>, IGroupService
{
    public GroupService(
        IAppUOW serviceUOW, 
        IBLLMapper<App.BLL.DTO.Group, App.DAL.DTO.Group> bllMapper) : base(serviceUOW, serviceUOW.GroupRepository, bllMapper)
    {
    }
}