# AcmeCorporation

### Getting started with the project

To be able to use and run the project, the following is needed:
- Visual Studio (.NET Core)
- Microsoft SQL server

It is fairly easy getting the project up and running:
- Clone the repository, open in Visual Studio or ZIP the project - whichever you feel like doing.
- After opening the project in Visual Studio build the solution and check if NuGet packages needs to be restored.

We now need to get the database running (Microsoft local SQL server)

- In Package Manager Console change default project to Persistence:
![](/images/pmc_persistence.png)

  - Run "Initial-Migration Initialize" - this will create the initial migration to the database with a seed of 100 serial numbers.
  - When finished applying Initial-Migration run "Update-database"

The project should be ready to run by now.

There are 3 pages to the web project:
- A landing page
- A create submission page
- A show submissions page

### Additional information
As the database is seeded with randomly generated serial numbers you will need to manually find one in the database.
This can easily be done in Visual Studio through SQL Server Object Explorer or Microsoft SQL Management Studio.
