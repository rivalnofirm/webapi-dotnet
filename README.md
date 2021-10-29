# webapi-dotnet
Create Restful API using ASP.NET CORE 3.1


## Installer Library
    - dotnet add package Microsoft.EntityFrameworkCore
    - dotnet add package Microsoft.EntityFrameworkCore.Design
    - dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    - dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection


## Migration database
    - dotnet ef migrations add InitialMigration
    - dotnet ef database update
    - dotnet ef migrations remove (remove database)