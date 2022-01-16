# Pierre's Sweet and Savory Treats

#### A web application that demonstrate many to many relationship with authentication and authorization in C#

#### Created By: Kate Kiatsiri

## Technologies Used

* C#
* CSS
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* ASP.NET MVC Identity
* MySql & MySql Workbench

## Description

A web application that users can create an account, log-in and log out. Only logged in users have ability to create, update and delete treats and flavors. A many to many relationship demonstrate between treats and flavors. All users are able to read and see the homepage.

Authentication Features:
- Anyone can access the index and details views
- Only authenticated users can access the Create, Update, Delete views
- The buttons on the navbar, Details and Index pages (for Treats and Flavors) change depending on authentication status

## Setup and Installation Requirements

### Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation and Setup

* Clone [this](https://github.com/keidsiri/PierresTreatAndFlavor) repository to your local machine
* navigate to the project directory `PierresTreatAndFlavor.Solution/PierresTreatAndFlavor`
* To install required packages, navigate to PierresTreatAndFlavor.Solutions/PierresTreatAndFlavor in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0
  - dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 5.0.0
* Create a file named "appsettings.json" in the PierresTreatAndFlavor directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=kate_kiatsiri2;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password

* To Import the required database:
   - In the terminal, navigate to PierresTreatAndFlavor.Solution/PierresTreatAndFlavor and run the command:
    ` dotnet ef database update `

* To Make Changes to the Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to PierresTreatAndFlavor.Solution/PierresTreatAndFlavor:
    ` dotnet ef migrations add YourDescriptionHere`
    ` dotnet ef database update`

* To Restore, build, and run the project in PierresTreatAndFlavor folder
  - Run the command "$ dotnet restore" to restore the project dependencies
  - Run the command "$ dotnet build" to build and compile the project
  - Run the command "$ dotnet run" to build and compile the project

## Known Bugs

* none 

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Kate Kiatsiri

## Contact Information

<h3> Kate Kiatsiri </h3>

[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/keidsiri)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/keidsiri)