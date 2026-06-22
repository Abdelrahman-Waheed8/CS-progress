# Introduction to PostgreSQL
At first like any other SQL Language or database system i created the database which basically the same in any other language:
```
CREATE DATABASE postgresql_part1;
```

To Run file to the database created we use the psql which the CLI for the database Engine
```
psql -U postgres -d postgres -f [filepath]
```

To get to the db itself:
```
psql -U postgres -d DBNAME 
```

To check what DB you are in right now:
```
SELECT current_database();
```

To check the version of postgres you're using: 
```
SELECT version();
```
\d to see the relations and \dt to see the tables in a db

### DB -> schema -> table -> rows

To create a schema for your db 
```
CREATE SCHEMA IF NOT EXISTS [schema name];
```

To create an extention which basically create a UUID Pk:
```
CREATE EXTENSION IF NOT EXISTS [extension name];
```