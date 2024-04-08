# FinOpp - Finance Solution
An app about finances.

## SUMMARY

* [Resume](#resume)
* [Dependencies](#dependencies)
* [Models](#models)
    * [Enum FinType](#enumearate-fintypeenum)
* [Use Cases](#use-cases)
* [Database](#database)

### Resume
This application has the objective to help our users to controll their money. Basically they can:

* Insert their earnings;
* Insert their expenses;
* Search for an existing order;
* Active or Deactive an order;
* Get a balance from a time range;

> **This application is built in C# (Csharp) programming language.**

### Dependencies

This is about the dependencies of the project. We have to install:

1. Npgsql - postgresql package for C#;
2. DotNet.Net - Load enviroment variables in C#;

To install that packages:

```commandline
dotnet add package npgsql
```

```commandline
dotnet add package dotnet.net
```

### Models
This is the tables of 2 entities of that project.

| **Users** | **Data Type** |
|-----------|---------------|
| ID        | BigInteger    |
| Name      | String        |
| DateBorn  | Date          |
| CPF       | String        |
| Username  | String        |
| *Email?*  | String        |
| Password  | String        |
| CreateAt  | DateTime      |
| *UpdateAt?* | Datetime    |

For each `User`, many others `FinOpp's`.

| **FinOpp** | **Data Type** |
|-----------|---------------|
| ID        | BigInteger    |
| UserId    | BigInteger(FK)|
| Category  | String        |
| TypeOpp   | FinTypeEnum*  |
| FinMoney  | Decimal       |
| CreateAt  | DateTime      |
| *UpdateAt?* | Datetime    |

#### Enumearate FinTypeEnum
This is a part of FinOpp table describe here.

```json
{
    "UNKNOWN",
    "INCOME",
    "EXPRESS"
}
```

### Use Cases

> [TODO]

### Database
This project uses database provide by [PostgreSQL](https://www.postgresql.org/). It's available a document `.sql` with the table's configuration [here](/fin_opp.sql).

That's all folks!
