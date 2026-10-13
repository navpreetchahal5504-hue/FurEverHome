# FurEverHome

FurEverHome is an ASP.NET Core MVC web application for managing pets that are
available for adoption at animal shelters. It stores data about shelters
(parent) and the pets housed in each shelter (child) in a SQL Server database
using Entity Framework Core. The site uses ASP.NET Identity (Individual User
Accounts) for authentication, which will be used in Assignment 2.

**Course:** COMP 2084 – Assignment 1
**Author:** YOUR NAME (Student # YOUR STUDENT NUMBER)

## Features (Assignment 1)
- MVC project with Individual User Accounts
- Models: Shelter (1) → Pet (many)
- Customized footer and home page

## Run it
1. Open in Visual Studio
2. Package Manager Console: `Add-Migration Initial` then `Update-Database`
3. Press F5
