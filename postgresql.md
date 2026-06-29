# Introduction to PostgreSQL
At first like any other SQL Language or database system i created the database which basically the same in any other language:
```
CREATE DATABASE postgresql_part1;
```
##### PostgreSQL uses a client/server model.


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

---

## Creating Table in PostgreSQL
### You need to specifiy the schema you're working on 
```
CREATE TABLE [schemaname].[tablename];
```
The first data type i encountered was the ```SERIAL``` which basically is an auto incrementer integer
so if we create a table

```
CREATE TABLE basics.students (
    id SERIAL PRIMARY KEY,              -- SERIAL IS CREATING AN AUTO INCREMENTING INTEGER
    name TEXT NOT NULL,                 -- text is string data, not null is a constraint which means that this column is required to fill
    email TEXT NOT NULL UNIQUE,         -- UNIQUE is constraint which means there is no value in the column is the same as other
    age INTEGER CHECK(age>= 18),        -- INTEGER is an integer and CHECK is a constraint that checks for something before inserting in the column
    created_at TIMESTAMP DEFAULT NOW()  -- TIMESTAMP is a data type where it stores dates, DEFAULT means the default value if not filled will be now
                                        -- NOW() is a functions that gets the time now
);
```

##### Also to see the tables in psql use \dt [schemaname].*

### INSERTING TO THE TABLE
We do normal inserting like any other database engine
``` 
INSERT INTO [tablename] (column names) VALUES (values name);
```
I've noticed it has thrown an error when i've used ``` " ``` instead of ``` ' ``` while inserting and the columns where basically of type ``` TEXT ```


You can also see that the data is inserted by navigating to your db by using the command: 
```
psql -U postgres -d DBNAME
```

and then use a normal SELECT query which will show you the rows inside your table so it should like this:
```
DBNAME-# SELECT * FROM [[schemaname].[tablename]];
```

I've also encountered some new datatypes:
```
CREATE TABLE basics.products_basic (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,    -- string but with max length of 100 characters
    description TEXT,              -- string type
    stock INTEGER DEFAULT 0,
    total_view BIGINT DEFAULT 0,   -- LARGE INTEGER --> BIGINT 
    price NUMERIC(10,2),           -- NUMERIC STORES FLOATING NUMBERS accepts two parameters the first one is the number of digits to accept and the second is the number of floating numbers
    is_active BOOLEAN DEFAULT true -- BOOLEAN true or false
);
```

```REAL``` is also a datatype in PostgreSQL where it rounds the value to the nearest value possible typically we use it for scientific measurements, temperature logs...etc

```date``` what differs date from timestamp is that timestamp stores the date with specific time but date only stores the date without any specific time 

```point``` datatype in PostgreSQL is used for storing coordinates of a point and you can access it by using [] as if indices

```UUID``` is a datatype in PostgreSQL that stores universally unique identifier you might need while specifiying the column the gen_random_uuid() to store a random UUID

```JSONB``` JSONB is a PostgreSQL data type that stores JSON data in a binary format. It's an enhanced version of the regular JSON type with significant performance and functionality advantages.
syntax for JSONB
```
colname JSONB DEFAULT '{}'::jsonb 
```
