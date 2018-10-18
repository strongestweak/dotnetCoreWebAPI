# BooksCoreAPI

I built this sample project using visual studio code

### Things you need
⋅⋅* Visual Studio Code
⋅⋅* .net core SDK
⋅⋅* .net core Hosting
⋅⋅* MSSQL Express or any version

### First Step: Create your project
1. Create a folder
2. Open your terminal/cmd
3. using your terminal/cmd navigate to the folder that you created
4. type this command "dotnet new webapi"
5. Press Enter then wait
6. type "code ." to open the project using Visual Studio Code

### Second Step Config your project
1. Create a "Models" folder
2. Right Click to that folder and choose "New C# Class"
3. Name the class based on what table name you desired. 
⋅⋅⋅In my case I named it books. I also created a BasedEntity and declared all those generic field name on that class, so that I don't need to recreat those fields in other model, I will just inherit class everytime I need those fields.
4. Open appsettings.json and create your connection string 
```Javascript
"ConnectionStrings": {
    "DefaultConnection": "Server=myServerName;Database=myDataBase;Trusted_Connection=True;"
  },
```


