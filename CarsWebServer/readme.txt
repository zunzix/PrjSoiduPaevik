# Car Journal


dotnet ef migrations add --project App.DAL.EF --startup-project WebApp --context AppDbContext InitialCreate

dotnet ef migrations --project App.DAL.EF --startup-project WebApp remove

dotnet ef database --project App.DAL.EF --startup-project WebApp update
dotnet ef database --project App.DAL.EF --startup-project WebApp drop



MVC controllers

cd WebApp

dotnet aspnet-codegenerator controller -name GroupsController -actions -m App.Domain.Group -dc AppDbContext -outDir Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -name GroupMembersController -actions -m App.Domain.GroupMember -dc AppDbContext -outDir Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -name CarsController -actions -m App.Domain.Car -dc AppDbContext -outDir Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -name CarLogsController -actions -m App.Domain.CarLog -dc AppDbContext -outDir Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -name CarIssuesController -actions -m App.Domain.CarIssue -dc AppDbContext -outDir Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f
dotnet aspnet-codegenerator controller -name CarInsurancesController -actions -m App.Domain.CarInsurance -dc AppDbContext -outDir Controllers --useDefaultLayout --useAsyncActions --referenceScriptLibraries -f

dotnet aspnet-codegenerator identity -dc App.DAL.EF.AppDbContext -f

Api controllers

dotnet aspnet-codegenerator controller -name GroupsController -m App.Domain.Group -dc AppDbContext -outDir ApiControllers -api --useAsyncActions -f
dotnet aspnet-codegenerator controller -name GroupMembersController -m App.Domain.GroupMember -dc AppDbContext -outDir ApiControllers -api --useAsyncActions -f
dotnet aspnet-codegenerator controller -name CarsController -m App.Domain.Car -dc AppDbContext -outDir ApiControllers -api --useAsyncActions -f
dotnet aspnet-codegenerator controller -name CarLogsController -m App.Domain.CarLog -dc AppDbContext -outDir ApiControllers -api --useAsyncActions -f
dotnet aspnet-codegenerator controller -name CarIssuesController -m App.Domain.CarIssue -dc AppDbContext -outDir ApiControllers -api --useAsyncActions -f
dotnet aspnet-codegenerator controller -name CarInsurancesController -m App.Domain.CarInsurance -dc AppDbContext -outDir ApiControllers -api --useAsyncActions -f


docker build -t webapp .
docker run --name webapp_docker --rm -it -p 8888:8080 webapp