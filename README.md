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
    ('Comprar leite', 'Comprar leite integral na loja mais próxima para o café da manhã'),
    ('Reunião de equipe', 'Participar da reunião semanal de planejamento de sprint'),
    ('Entregar relatório', 'Finalizar e enviar o relatório de vendas para o diretor'),
    ('Revisão de código', 'Revisar o código da feature X para aprovação'),
    ('Comprar ingressos para cinema', 'Comprar ingressos para o filme "Vingadores" na sexta-feira à noite'),
    ('Almoçar com cliente', 'Almoçar com o cliente ABC para discutir novos projetos'),
    ('Configurar servidor', 'Configurar o novo servidor de produção para a aplicação de vendas'),
    ('Planejar viagem de negócios', 'Planejar viagem para a conferência em São Paulo na próxima semana');
   ```

### Step 2: Run the Project

Run the project with the command:

```
cd GraphQL.API && dotnet run
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
