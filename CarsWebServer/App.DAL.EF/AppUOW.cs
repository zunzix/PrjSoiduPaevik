using App.DAL.Contracts;
using App.DAL.EF.Repositories;
using Base.DAL.EF;

namespace App.DAL.EF;

public class AppUOW : BaseUOW<AppDbContext>, IAppUOW
{
    public AppUOW(AppDbContext uowDbContext) : base(uowDbContext)
    {
    }

    private IGroupRepository? _groupRepository;
    public IGroupRepository GroupRepository =>
        _groupRepository ??= new GroupRepository(UOWDbContext);
    
    private IGroupMemberRepository? _groupMemberRepository;
    public IGroupMemberRepository GroupMemberRepository =>
        _groupMemberRepository ??= new GroupMemberRepository(UOWDbContext);
    
    private ICarRepository? _carRepository;
    public ICarRepository CarRepository =>
        _carRepository ??= new CarRepository(UOWDbContext);
    
    private ICarLogRepository? _carLogRepository;
    public ICarLogRepository CarLogRepository =>
        _carLogRepository ??= new CarLogRepository(UOWDbContext);
    
    private ICarIssueRepository? _carIssueRepository;
    public ICarIssueRepository CarIssueRepository =>
        _carIssueRepository ??= new CarIssueRepository(UOWDbContext);
    
    private ICarInsuranceRepository? _carInsuranceRepository;
    public ICarInsuranceRepository CarInsuranceRepository =>
        _carInsuranceRepository ??= new CarInsuranceRepository(UOWDbContext);
    
}