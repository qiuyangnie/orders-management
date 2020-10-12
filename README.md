# orders-management

## Introduction:
* This document includes basic but instrumental design process for approaching the assessment, instructions to use the application, and project critical evaluation.

## Instructions:
```
https://localhost:5001/customer
https://localhost:5001/product
https://localhost:5001/order
```

## Design Process:
* **Relational Database Design Process**

###### **Step 1**: Define the Purpose of the Database (Requirement Analysis)
* Assessment.

###### **Step 2**: Gather Data, Organize in tables and Specify the Primary Keys
* Subject-based tables: ***Product***, ***Order***, ***Customer***, ***Status***.
* The `Id` field of each table is set to the *primary key* because it is *fact-less*, as it contains no factual information. Unlike factual information such as phone number, fact-less number is ideal for primary key, as it does not change.

###### **Step 3**: Create Relationships among Tables
* One-to-Many: ***Customer***-***Order*** 
  * A customer may place many orders; while an order is placed by one particular customer.
    * The column `CustomerId` in the child table ***Order*** is the *foreign key*.
* Many-to-Many: ***Order***-***Product***
  * A customer's order may contain one or more products; and a product can appear in many orders.
    * A *junction table* ***OrderDetail*** is needed to support the relation, where each row represents an item of a particular order. For the ***OrderDetail*** table, the primary key consists of two columns: `OrderId` and `ProductId`, that uniquely identify each row. The columns `OrderId` and `ProductId` in ***OrderDetail*** table are used to reference ***Order*** and ***Product*** tables, hence, they are also the foreign keys in the ***OrderDetail*** table.
* One-to-One: ***Order***-***Status***
  * A product may have optional supplementary information such as Status. Keeping them inside the ***Product*** table results in many empty spaces (in those records without these optional data). Furthermore, these large data may degrade the performance of the database.
* Summary:
  * ***Product***: `ProductId`(PK), `Name`, `Price`, `Description`, `CreationDate`, `ExpiredDate`
  * ***Order***: `OrderId`(PK), `CreationDate`, `EstimateDate`, `CustomerId`(FK)
  * ***OrderDetail***: `OrderId`(PK, FK), `ProductId`(PK, FK), `quantity`
  * ***Customer***: `CustomerId`(PK), `Fname`, `Lname`, `Address`, `Phone` 
  * ***Status***: `OrderId`(PK), `Name`
  
###### **Step 4**: Refine & Normalize the Designs (Author's belief but it is optional for assessment)
* Normalization: All tables can comply *3NF*:
    * Every cell contains a single value, not a list of values.
    * Every non-key column is fully dependent on the primary key, only on the primary key and nothing else.
* Integrity Rules
  * *Entity Integrity Rule*: The primary key cannot contain `NULL`. Otherwise, it cannot uniquely identify the row. For composite key made up of several columns(***OrderDetail*** table), none of the column can contain NULL. However, most of the RDBMS check and enforce this rule.
  * *Referential Integrity Rule*: Each foreign key value must be matched to a primary key value in the table referenced (or parent table).
    * If the value of the key changes in the parent table (e.g., the row updated or deleted), all rows with this foreign key in the child table(s) must be handled accordingly. There are many options to comply with the rule: (a) disallow the changes; (b) cascade the change (or delete the records) in the child tables accordingly; (c) set the key value in the child tables to `NULL`. The option (b) is chosen because frequent transaction is expected in Orders Management system.
  * *Business logic Integrity*: TODO

## Critical Evaluation:
