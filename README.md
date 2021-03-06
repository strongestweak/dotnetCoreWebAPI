# BooksCoreAPI

I built this sample project using visual studio code

### Things you need
* Visual Studio Code
* .net core SDK
* .net core Hosting
* MSSQL Express or any version

### Create your project
1. Create a folder
2. Open your terminal/cmd
3. using your terminal/cmd navigate to the folder that you created
4. type this command "dotnet new webapi"
5. Press Enter then wait
6. type "code ." to open the project using Visual Studio Code

### Config your project
1. Create a "Models" folder
2. Right Click to that folder and choose "New C# Class"
3. Name the class based on what table name you desired. 

...In my case I named it books. I also created a BasedEntity and declared all those generic field name on that class, so that I don't need to recreat those fields in other model, I will just inherit class everytime I need those fields.
4. Open appsettings.json and create your connection string 
```Javascript
"ConnectionStrings": {
    "DefaultConnection": "Server=myServerName;Database=myDataBase;Trusted_Connection=True;"
  },
```

5. Create DataAccess Folder
6. Create DataContext class inside that folder
...See DataAccess Folder for reference
7. Configure Startup.cs
8. Configure .csproj


### Migrations
1. Open Terminal
2. Navigate to the project folder
3. Build your project "dotnet build" and wait
4. Create Migrations file "dotnet ef migrations add TitleOfMigrations"
5. Migrate "dotnet ef database update"
6. Check database

### Create Controller
1. Right Click Controllers Folder 
2. Choose New C# Class
3. Name it ModelNameControllers.cs
4. Inherit ControllerBase Class
5. Create your methods
6. See BooksController.cs for basic CRUD code


### HTTP Methods
1. HttpPost - Insert
2. HttpGet - Retrieve Data from Database
3. HttpPut - Update
4. HttpDelete - Deletes


