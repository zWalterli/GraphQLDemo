# GraphQL API Example

Este repositório contém um exemplo de uma API GraphQL construída com .NET. Ele permite realizar consultas em uma lista de tarefas (`TaskItem`) e inclui uma consulta que pode ser filtrada por `id`, `title` e `description`.

## Requisitos

- [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet) ou superior
- [SQLite](https://www.sqlite.org/download.html) para o banco de dados

## Como Criar e Rodar o Banco de Dados

### Passo 1: Criar o Banco de Dados `App.db`

1. **Crie o banco de dados manualmente**: Para isso, você pode utilizar uma ferramenta como [DB Browser for SQLite](https://sqlitebrowser.org/), ou utilizar o SQLite diretamente no terminal para criar o banco de dados e a tabela.

2. **Criar a Tabela Manualmente**:

   No DB Browser for SQLite ou ferramenta similar, crie uma nova base de dados chamada `App.db` dentro da pasta `GraphQL.API`. Em seguida, crie a tabela `Tasks` com a seguinte estrutura:

   ```sql
   CREATE TABLE Tasks (
       Id INTEGER PRIMARY KEY AUTOINCREMENT,
       Title TEXT NOT NULL,
       Description TEXT NOT NULL
   );
   ```

3. **Inserir Dados**:

   Após criar a tabela, insira dados reais para representar tarefas:

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

### Passo 2: Rodar o Projeto

Execute o projeto com o comando:

```
dotnet run
```

O servidor será iniciado, e a API GraphQL estará disponível em http://localhost:5000/graphql.

### Passo 3: Como Consumir a Query GraphQL

Você pode consumir a API usando um cliente GraphQL como Postman, Insomnia ou diretamente em uma interface como GraphiQL.

Exemplo de Query:

```graphql
query {
  tasks(title: "", description: "") {
    id
    title
    description
  }
}
```

Exemplo de Resposta:

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
