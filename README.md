# NutzDotNet6Mvc

@ NutzWeb

> 000 - Create Project MVC

- Nuget -> Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation -> Install
- Add -> Class -> Models -> Category.cs -> // 000 - Create Project
- Edit -> appsettings.json -> // 000 - Create Project
- Add -> New Folder -> Data
- Nuget -> Microsoft.EntityFrameworkCore -> Install
- Add -> Class -> Data -> ApplicationDbContext.cs -> // 000 - Create Project
- Nuget -> Microsoft.EntityFrameworkCore.SqlServer -> Install
- Edit -> Program.cs -> // 000 - Create Project
- Nuget -> Microsoft.EntityFrameworkCore.Tools -> Install
- Console -> Add-Migration AddCategoryToDatabase -> Update-Database

> 001 - Category

- Add -> Controllers -> CategoryController.cs
- Add View -> Index -> Razor View
- Edit -> Views -> Shared -> Layout.cshtml -> @*001 - Category*@
- Edit -> Controllers -> CategoryController.cs -> // 001 - Category
- Edit -> Views -> Category -> Index.cshtml -> @*001 - Category*@
- Edit -> wwwroot -> css -> site.css -> /*001 - Category*/
- Add View -> Create -> Razor View
- Edit -> Views -> Category -> Create.cshtml -> @*001 - Category*@
- Edit -> Models -> Category.cs -> // 001 - Category
- Add View -> Edit -> Razor View
- Edit -> Views -> Category -> Edit.cshtml -> @*001 - Category*@
- Add View -> Delete -> Razor View
- Edit -> Views -> Category -> Delete.cshtml -> @*001 - Category*@
- Add View -> Shared -> Razor View -> partial view
- Edit -> Views -> Shared -> Notification.cshtml -> @*001 - Category*@

@ DCWeb

> 002 - Create Project Razor

- Add -> Project -> ASP.Net Core Web App
- Add -> Class -> Models -> Category.cs
- Edit -> Models -> Category.cs -> // 002 - Create Project DCWeb
- Edit -> appsettings.json -> // 002 - Create Project DCWeb
- Nuget -> Microsoft.EntityFrameworkCore -> Install
- Nuget -> Microsoft.EntityFrameworkCore.SqlServer -> Install
- Add -> New Folder -> Data
- Add -> Class -> Data -> ApplicationDbContext.cs -> // 002 - Create Project DCWeb
- Edit -> Program.cs -> // 002 - Create Project DCWeb
- Nuget -> Microsoft.EntityFrameworkCore.Tools -> Install
- Console -> Add-Migration AddCategoryToDb -> Update-Database

> 003 - Category

- Add -> New Folder -> Pages -> Categories
- Add -> Categories -> Razor Page - Empty -> Index.cshtml
- Edit -> Index.cshtml.cs -> // 003 - Category
- Edit -> Index.cshtml -> @*003 - Category*@

