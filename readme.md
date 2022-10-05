New Mvc App Using Identity to a mySlq Database

1.dotnet new mvc --auth Individual -o Name
2.Go to ProjectName.csproj file and will see all the packages
3.Install all the packages
-My Sql packages => dotnet add package MySQL.Data.Entities --version 6.8.3
dotnet add package Pomelo.EntityFrameworkCore.MySql --version 6.0.2
dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.9

-Update the global tools to the latest available version =>dotnet tool update --global dotnet-ef

Change the program.cs file 

 delete this =>
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(connectionString));

 add this  =>
builder.Services.AddDbContext<ApplicationDbContext>(options =>{
    options.UseMySql(connectionString, Server…


    dotnet aspnet-codegenerator identity -dc WebApplication1.Data.ApplicationDbContext