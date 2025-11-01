# RouteG04 MVC Project

## Overview

An ASP.NET MVC project built with a three-tier architecture to keep the code organized, maintainable, and easy to evolve.

## Architecture

The solution is divided into three separate layers:

**RouteG04.PL — Presentation Layer**  
Responsible for the user interface and handling HTTP requests. Contains the application’s Controllers and Views.

**RouteG04.BLL — Business Logic Layer**  
Implements business rules and application logic. Acts as the intermediary between the presentation and data layers.

**RouteG04.DAL — Data Access Layer**  
Handles database operations and implements CRUD functionality.

## Tech Stack

- ASP.NET MVC
- C#
- Entity Framework (if used)

## Prerequisites

- Visual Studio 2012 or later
- .NET Framework
- SQL Server (depending on your database setup)

## Getting Started

1. Clone the repository to your machine:
```bash
git clone https://github.com/shi7a505/.Net-project.git
```

2. Open the solution file `RouteG04MVCProject.sln` in Visual Studio.

3. Restore NuGet packages if prompted.

4. Update the connection string in `web.config` to match your database settings.

5. Run the project.

## Notes

- Ensure the connection strings are configured before running the application.
- New features should be added to the appropriate layer to keep responsibilities separated.
- Following the three-tier architecture simplifies development, testing, and maintenance.

## License

This project is available for use and development.
