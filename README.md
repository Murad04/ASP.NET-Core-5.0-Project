# MM Blogs
An online platform for writing and reading blogs .
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------
#### Video Demo: <URL>
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 ## Description:
  
#### Project Layers:
-  <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/EntityLayer">Entity Layer </a> is a layer contains model
-  <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/DataAccessLayer"> Data Access Layer </a> is a layer contains DB Migrations, interfaces for model's repositories and generic repository.
-  <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/BusinessLayer"> Business Layer </a> is a layer contains all business logics for DB.
-  <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/API" >API</a> contains an API for getting data from DB .
-  ##### <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/WebApplication7" > UI layer </a> contains :
    - <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/WebApplication7/Controllers"> Controllers </a>
    - <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/WebApplication7/Models"> Models </a>
    - <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/WebApplication7/ViewComponents"> View Components </a>
    - <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/WebApplication7/Views"> Views </a>
    - <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/WebApplication7/Areas/Admin"> UI for Admin </a>.

#### Definition of files:
  
  - #####  EntityLayer
    1. All of the <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/EntityLayer/Concrete"> classes </a> are the model of table for DB.
  - ##### DataAccessLayer
    1. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/DataAccessLayer/Migrations"> They </a> are migration files createdf automatically when creating or updating the DB with EF Core.
    2. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/DataAccessLayer/EntityFramework"> They </a> are classes for DB queries for each model.
    3. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/blob/main/DataAccessLayer/Repositories/GenericRepository.cs"> Generic Repository class </a> contains common queries for each model and each EntityFramework class use it.
    4. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/DataAccessLayer/Abstract">They</a> are interfaces contains individual queries for each model.
    5. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/blob/main/DataAccessLayer/Concrete/Context.cs">It </a> is a context class which is contains DbSets anf relations for DB. And EF Core uses this class to do CRUD operations on DB.
  - ##### BusinessLayer
    1. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/BusinessLayer/ValidationRules">They</a> are ValidationRules writed with FluentValidation for each model.
    2. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/BusinessLayer/Concrete"> They</a> are classes for managing the models.
    3. <a href="https://github.com/Murad04/ASP.NET-Core-5.0-Project/tree/main/BusinessLayer/Abstract">They</a> are services for each model.(They are an interface).
   
#### Role of files (MVC Design Pattern used!)
  - ##### Controllers --> Controllers accepts input and converts it to commands for the model or view.
  - ##### Models --> In simple terms, this logic is used to handle the data passed between the database and the user interface (UI).
  - ##### Views --> Shows the app's data in UI.
