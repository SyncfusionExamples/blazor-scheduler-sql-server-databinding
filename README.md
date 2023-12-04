# Blazor-Scheduler-SQL-Server-Databinding

A quick start project that shows how to consume data from SQL Server using Microsoft SqlClient and bound it to Blazor Scheduler.

**Documentation**: https://blazor.syncfusion.com/documentation/scheduler/data-binding#sql-server-data-bindingsql-client

## Prerequisites

* Visual Studio 2022
* Ensure that you are having SQL Server Data Tools within Visual Studio 2022.

# How to run the project

* Checkout this project to a location in your disk.
* Open the solution file using the Visual Studio 2022.
* Restore the NuGet packages by rebuilding the solution.
* Using the Migrations create the database by running the following command in the Package Manager console:
> PM> update-database
* Migrations automate the creation of database based on our Model. The EF Core packages required for migration will be added with .NET Core project setup.
* Run the project.
