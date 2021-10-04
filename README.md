# Sprouty
ENG4003_090 Fall Project

Getting Started:

Clone the repository to your local machine
Install NuGet Packages: 
  In Visual Studio > Tools > NuGet Package Manager > Manage NuGet Packages for Solution...
  - AutoMapper 10.1.1
  - AutoMapper.Extensions.Microsoft.DependencyInjection 8.1.1
  - Microsoft.AspNetCore.SpaServices.Extensions 5.09
  - Microsoft.EntityFrameworkCore 5.09
  - mongocsharpdriver 2.13.1
  - Serilog 2.10.0
  - Serilog.Settings.Configuration 3.2.0
  - Serilog.Sinks.File 5.0.0
  - Serilog.Sinks.MongoDB 5.0.0

  - Swashbuckle.AspNetCore.SwaggerGen 6.2.1
  - Swashbuckle.AspNetCore.SwaggerUI  6.2.1
  - Swashbuckle.AspNetCore.Swagger    6.2.1
  - Microsoft.AspNetCore.Authentication.JwtBearer 5.0.10
  

Check to make sure that these packages are installed to the solution and test the application will build/run through IIS Express debug mode. The first time you launch the debugger, Visual Studio will run all the npm installs associated with the Angular client so this might take a minute or two before anything happens.

The MongoDB connection string can be found in appsettings.json, but should not need to be changed. If we want, we can each have our own account and connection string to access the MongoDB, but for now I'm just sharing mine. This repo is private so there should not be any issues
  
