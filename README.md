<h1 align="center">
<!--   <img alt="Project's logo" src="https://github.com/user-attachments/assets/bbf2fd04-d808-47a4-a9d0-a50f269f771d" width="140px" align="left" /> -->
  Company CRUD
</h1>

<p align="left">
  ⚙️ A simple ASPNET MVC application to create companies. Made with .NET Framework 4.8.1
  <br />
</p>
<br/>

## 👀 Overview
<div>
  Index:
  <img src="https://github.com/user-attachments/assets/24ccb257-008e-48da-b204-fef6ceb22458" />
  Creating new company:
  <img src="https://github.com/user-attachments/assets/6f006459-ac47-4190-b470-7ad774512bd1" />
  Editing company:
  <img src="https://github.com/user-attachments/assets/0b124372-8945-45e7-964e-461a70b5e9ea" />
  View details:
  <img src="https://github.com/user-attachments/assets/e669f3b7-b497-48cb-8241-5be39191a1bf" />
  Deleting:
  <img src="https://github.com/user-attachments/assets/80a1d0d0-ec18-4379-b6c7-cddab08970db" />
</div>

## 📖 About

ImportCrud is an ASP.NET MVC application targeting .NET Framework 4.8.1. The application provides a platform for managing user authentication, external logins, and basic CRUD operations. It leverages ASP.NET Identity for user management and authentication.

## 🧱 This project was built with:

- [.NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
- [SQL Server](https://www.microsoft.com/en/sql-server/sql-server-downloads)
- [Entity Framework 6](https://learn.microsoft.com/en-us/ef/ef6/)
- [Bootstrap 5](https://getbootstrap.com/)

## 🚶‍♂️ Installing and Running

> If you haven't downloaded .NET Framework 4.8.1 yet you can download it here [Download .NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/net481)
> 
> You can download SQL Server here [SQL Server Downloads | Microsoft](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) and SQL Server Management Studio here [Download SQL Server Management Studio (SSMS)](https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16)

1.  Clone this repository `[git clone https://github.com/lmraes/aspnet-mvc-crud-empresa.git]`
2.  Open the solution `TreinamentoDotNet/TreinamentoDotNet.sln` in Visual Studio
3.  Restore the Nuget packages
4.  Change the connection string in `TreinamentoDotNet/Web.config`
5.  Build the project
6.  Run the following commands in the Package manager console to update the database 
```bash
Update-Database -ConfigurationTypeName ConfigurationIdentity  -Verbose
Update-Database -ConfigurationTypeName ConfigurationImportCrud -Verbose
```
