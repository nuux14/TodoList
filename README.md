Blazor Server Todo list app
==============================

[![MIT License](https://img.shields.io/github/license/nuux14/TodoList?color=%230b0&style=flat-square)](https://github.com/nuux14/TodoList/blob/main/LICENSE)
[![Open Issues](https://img.shields.io/github/issues/nuux14/TodoList/good%20first%20issue?color=%23512BD4&label=good%20first%20issue&style=flat-square)](https://github.com/nuux14/TodoList/issues?q=is%3Aissue+is%3Aopen+label%3A%22good+first+issue%22)

A simple asp.net core blazor server todo list app (.NET 7). In this project we are using SQLite database

### Visual Studio Code (or any code editor)

1. Navigate to the `TodoList` folder 
1. If you haven't installed the EF Core Command Line Interface (CLI), install it by following [these instructions](https://docs.microsoft.com/ef/core/miscellaneous/cli/dotnet). Choose the latest stable version (the project file currently ships with version 7.0.9).
1. This migration step has already been done but for reference this is what you'd have done: 

    ```text
   dotnet ef migrations add Initial
    ``` 

    or if you would want you could specify the DbContext option like this:


    ```text
   dotnet ef migrations add --context TodoDbContext Initial
   ```
   
    to set up the  database migrations (already done).
1. Run 

    ```text
   dotnet ef database update
   ``` 
    
    to create the TodoList database.
1. Type 

   ```text
   dotnet run` or `dotnet watch
   ```
    
   to start the server. Navigate to the port specified.
  
> **Note**: the demo app is designed to create the TodoList database the first time you open the web page. This may result in a delay of up to several minutes on first load. This is normal and is just used to make setup easier. Subsequent runs should load faster.

## Migrations for TodoList Database

The context for TodoItems (`TodoDbContext`) resides in the `TodoList` assembly.  To create a migration, you must specify the executable startup project and the context name. This command will create a migration in the `Migrations` folder (assuming this is run from the root of the project directory):

```text
dotnet ef migrations add  InitialTodoList
```

---

Submit any feedback, questions, suggestions, or issues [here](https://github.com/nuux14/TodoList/issues/new).

Regards,

![Mubarek Abdi](https://github.com/nuux14)

[@nuux14](https://twitter.com/May28_2023)
