# How to bind Blazor Scheduler with SQL Server using Entity Framework Core

This quick start project demonstrates how to consume data from SQL Server using Microsoft SqlClient and integrate it with the [Blazor Scheduler](https://www.syncfusion.com/blazor-components/blazor-scheduler) through Entity Framework Core. It showcases performing CRUD operations on scheduling data with SQL-backed persistence, providing a practical example of seamless data binding, synchronization, and database-driven event management in Blazor applications.

## Features

* **SQL Server Data Binding**: Direct connection to SQL Server databases using Microsoft SqlClient
* **Entity Framework Core**: Leverages EF Core for database operations and migrations
* **CRUD Operations**: Complete create, read, update, and delete functionality
* **Real-time Synchronization**: Automatic data synchronization between UI and database
* **Appointment Management**: Full scheduling capabilities with event persistence

## Technologies Used

* **Blazor**: Server-side rendering for interactive web applications
* **SQL Server**: Relational database for event storage
* **Entity Framework Core**: ORM for database access and management
* **Microsoft SqlClient**: Direct SQL Server data provider
* **Visual Studio 2026 (or Visual Studio 2022 17.14+)**: Development environment

## Prerequisites

* Visual Studio 2026 (or Visual Studio 2022 17.14+)
* SQL Server Data Tools within Visual Studio 2026 (or Visual Studio 2022 17.14+)
* .NET 10.0 SDK or later
* SQL Server 2016 or later

## Installation

1. Checkout this project to your local machine
2. Open the solution file using Visual Studio 2026 (or Visual Studio 2022 17.14+)
3. Build the solution to restore the required NuGet packages

## Database Setup

This project uses Entity Framework Core migrations to manage the database schema. Follow these steps to initialize the database:

1. Open the Package Manager Console in Visual Studio.
2. Run the following command:
   ```
   PM> update-database
   ```
3. Migrations automatically create the database based on the defined models.
4. The EF Core packages required for migration are included with the .NET Core project setup.

## How to Run the Project

* Ensure the database has been created using the migration command above.
* Build the solution to restore all NuGet dependencies.
* Run the project in Visual Studio.
* The Blazor Scheduler will load with SQL Server data binding enabled.
* You can now perform scheduling operations with full CRUD functionality.

## Documentation

For comprehensive information about Blazor Scheduler and SQL Server data binding:

* **Syncfusion Blazor Scheduler - Introduction**: https://blazor.syncfusion.com/documentation/introduction
* **Blazor Scheduler - Getting Started**: https://blazor.syncfusion.com/documentation/schedule/getting-started
* **Blazor Scheduler - SQL Server Data Binding**: https://blazor.syncfusion.com/documentation/scheduler/data-binding#sql-server-data-bindingsql-client

## Support & Resources

For additional resources and support with Syncfusion Blazor Scheduler, visit the official documentation portal at https://blazor.syncfusion.com/documentation/
