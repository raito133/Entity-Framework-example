#Entity-Framework-example
This app shows an example of code-first approach with Entity Framework and Dependency Injection (repository pattern). CRUD is implemented for tables Artists, Albums and Tracks.
You have to have a database server installed (i.e. Microsoft SQL Server) and specify the connection string in the App.config file.

#Database migration
- Change the connection string in app.cofig file
- Launch NuGet console in Visual Studio and use the following commands to add your migration: Add-Migration <migrationName> Update-Database

