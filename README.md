# FormBizzApplication
Form based application, provides a strong architectural model based on Domain Driven Design, with all the best practices in mind. FormBizzuses the latest ASP.NET  Core &amp; EF Core frameworks.

The core FormBizz application comprises several components:

aspnetzero. a boiler plate framework which provides out the box support for our multi-tenanted application,
form.io  for JSON form schema,
aspose.com  for document assembly
Microsoft VSTS, word Add-In
If you would like to install everything locally and you aren't familiar with how to set up your development environment for these, you can click on the Developer Workstation link to show you everything you need know to know.

Otherwise, you can head over here, grab a copy of the source code and get started!

# Overview
The components of the application and their relationships.

Syntaq provides a strong architectural model based on Domain Driven Design, with all the best practices in mind. Syntaq uses the latest ASP.NET  Core & EF Core frameworks.

ASP.NET  Core 3.1
Azure SQL Server
Azure Web application hosting infrastructure
The layering of an application's codebase is a widely accepted technique to help reduce complexity and to improve code reusability. To achieve a layered architecture, SYNTAQ follows the principles of Domain Driven Design delivered using a MCV pattern.

Domain Driven Design Layers
There are four fundamental layers in Domain Driven Design (DDD):

Presentation Layer: Provides an interface to the user. Uses the Application Layer to achieve user interactions.
Application Layer: Mediates between the Presentation and Domain Layers. Orchestrates business objects to perform specific application tasks.
Domain Layer: Includes business objects and their rules. This is the heart of the application.
Infrastructure Layer: Provides generic technical capabilities that support higher layers mostly using 3rd-party libraries.


# Prerequisites
Install Visual Studio, minimum version 15.4.4. Recommended Edition is Professional or Enterprise. When installing, make sure you include the Mobile development with .NET using Xamarin option.

Install MS SQL Server & MS SQL Server Management Studio.

Run & connect MS SQL Server Management Studio to your local DB instance.

In the left-hand navigation bar, underneath the server instance, right click on the Databases folder and select New Database.

Enter the database name FromBizzDb.

Download Node.js & follow the installation wizard through. https://nodejs.org/en/download/

Download Yarn & follow the installation wizard through. https://yarnpkg.com/lang/en/docs/install/#windows-stable

To install Gulp, open up a new command prompt window and run "npm install gulp@next -g"

Before opening the solution open a command prompt in the root directory of *.Web.Mvc project and run "yarn" command to install client-side dependencies.
Before running the project, we need to run a npm task to bundle and minify the CSS and JavaScript files. In order to do that, we can open a command prompt, navigate to root directory of *.Web.Mvc project and run npm run create-bundles command. This command should be run when a new npm package is being added to the solution

Run Visual Studio, then //How to connect to Team Server

Download a copy of FormBizz from Team Services/Server?

Load the project, then go Tools > NuGet Package Manager > Package Manager Console. This will open the Package Manager Console at the bottom of the window.

Make sure Default Project is set to FormBizz.EntityFrameworkCore at the top of the Package Manager Console.

Inside the console, type "Add-Migration", then when prompted, supply the name of the database (FormBizzDb).

Next type in the console window "Update-Database". This will generate a local copy of the latest database structure.
