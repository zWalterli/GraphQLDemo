# GraphQL API

This repository contains an example of a GraphQL API built with .NET. It allows you to query a list of tasks (TaskItem) and includes a query that can be filtered by id, title, and description.

## Requirements

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet) or later
- [SQLite](https://www.sqlite.org/download.html) for the database

## How to Create and Run the Database

### Step 1: Create the `App.db` Database

1. **Create the database manually**: You can use a tool like [DB Browser for SQLite](https://sqlitebrowser.org/) or use SQLite directly from the terminal to create the database and table.

2. **Create the Table Manually**:

   In DB Browser for SQLite or a similar tool, create a new database named `App.db` inside the `GraphQL.API`. folder. Then create the Tasks table with the following structure:

   ```sql
   CREATE TABLE Tasks (
       Id INTEGER PRIMARY KEY AUTOINCREMENT,
       Title TEXT NOT NULL,
       Description TEXT NOT NULL
   );
   ```

3. **Insert Data**:

   After creating the table, insert real data to represent tasks:

   ```sql
   INSERT INTO Tasks (Title, Description)
    VALUES
    ('Buy milk', 'Buy whole milk at the nearest store for breakfast'),
    ('Team meeting', 'Attend the weekly sprint planning meeting'),
    ('Submit report', 'Finish and send the sales report to the director'),
    ('Code review', 'Review the code for feature X for approval'),
    ('Buy movie tickets', 'Buy tickets for the movie "Avengers" on Friday night'),
    ('Lunch with client', 'Have lunch with client ABC to discuss new projects'),
    ('Configure server', 'Set up the new production server for the sales application'),
    ('Plan business trip', 'Plan the trip to the conference in São Paulo next week');
   ```

### Step 2: Run the Project

Run the project with the command:

```
dotnet run
```

The server will start, and the GraphQL API will be available at http://localhost:5037/graphql.

### Step 3: How to Query the GraphQL API

You can consume the API using a GraphQL client such as Postman, Insomnia, or directly through a GraphiQL interface.

Example Query:

```graphql
query {
  tasks(title: "", description: "") {
    id
    title
    description
  }
}
```

Example Response:

```json
{
  "data": {
    "tasks": [
      {
        "id": 1,
        "title": "Task 1",
        "description": "Description for Task 1"
      },
      {
        "id": 2,
        "title": "Task 2",
        "description": "Description for Task 2"
      }
    ]
  }
}
```
