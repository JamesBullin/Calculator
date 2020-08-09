# Databases

## Terminology

* Structured data, accessed in various ways
* Relational database: access multiple tables; connected data
* Row / Column : Attribute / Occurence
* DMBS: Database management system
* PK: Primary key; unique identifier; autoincrement; unique; not null;
  * Can by simple or compound: multiple attributes must be used to determine uniqueness
* FK: Foreign Key: Create relationship to another key
  * Prevents invalid data
  * Prevents a record from being deleted if it is used by another table

## Software

[![error message](https://image.shutterstock.com/image-photo/white-transparent-leaf-on-mirror-260nw-1029171697.jpg)](https://www.youtube.com/watch?v=c1XB2IorNTM)

* MS Access: hard to scale
* SQL 
  * SSMS; MS Sql; MySql; Oracle;
  * PostgreSQL: Object-relational database
  * Redis: Key-value pairs
* SQLite
* Big data: MongoDB / Vertica: IoT
  * Document-oriented; not relational
* LucidChart / **Visio**

## Types of commands [On the test]

* DML - Data manipulation language - Edit
* DDL - Data definition language - Structure
* Data Control Language - Access
* Transaction Control Language - Version control

## Relational database

* Schema; diagram; ERD: Entity-relationship diagram

![image-20200730121932398](C:\Users\James Bullin\AppData\Roaming\Typora\typora-user-images\image-20200730121932398.png)

## SQL 

`CREATE DATABASE Eng65`

`CREATE TABLE film
(`

` 	ID INT IDENTITY (1,1) PRIMARY KEY NOT NULL
	,Name VARCHAR(50)
	,Genre VARCHAR(20)
)`

`SP_HELP myTable`

`UPDATE myTable SET column1 = 'hello' WHERE ID = 2;`

`DELETE FROM myTable WHERE ID = 2;`

`TRUNCATE TABLE myTable;`

## Types

* VARCHAR
* CHAR
* BINARY
* FLOAT
* DECIMAL / NUMERIC

INT (CHECKK > 18) ???

Primary Key first

`ALTER TABLE myTable ADD rating DEC (2,1);`

## Null Default

* Null : No information
* Default: value input when no value is provided

## Normalisation

Linking database

Reducing redundancy and dependency

Organising fields and table 

The main aim of normalisation is to add, delete or modify fields that can be made in a single table

* Don't repeat data in columns

* 1st Normal form: Remove all duplicate data
  * All data as small as it can be
* 2nd Not two columns have 'the same information'
* 3rd: No transitive functional dependency

*SOLID principles of OOP : Single responsibility principle.*

**WATCH VIDEO TO EXPLAIN**