# NutzDotNet6Mvc

@ NutzWeb

> 000 - Create Project

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
