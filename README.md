# orders-management

## Relational Database Design Process
### Step 1: Define the Purpose of the Database (Requirement Analysis)
* Assessment.

### Step 2: Gather Data, Organize in tables and Specify the Primary Keys
* Subject-based tables: ***Product***, ***Order***, ***Customer***, ***Status***.
* The `Id` field of each table is set to the *primary key* because it is *fact-less*, as it contains no factual information. Unlike factual information such as phone number, fact-less number is ideal for primary key, as it does not change.

### Step 3: Create Relationships among Tables
* **One-to-Many**
  * ***Customer*** - ***Order*** 
    * A customer may place many orders; while an order is placed by one particular customer.
    * The column ***Customer_Id*** in the child table ***Order*** is the *foreign key*.
* **Many-to-Many**
  * ***Order*** - ***Product***
    * A customer's order may contain one or more products; and a product can appear in many orders.
    * A *junction table* ***OrderDetail*** is needed to support the relation, where each row represents an item of a particular order. For the ***OrderDetail*** table, the primary key consists of two columns: ***Order_Id*** and ***Product_Id***, that uniquely identify each row. The columns ***Order_Id*** and ***Product_Id*** in ***OrderDetail*** table are used to reference ***Order*** and ***Product*** tables, hence, they are also the foreign keys in the ***OrderDetail*** table.
* **One-to-One**
  * ***Order*** - ***Status***
    * A product may have optional supplementary information such as Status. Keeping them inside the Products table results in many empty spaces (in those records without these optional data). Furthermore, these large data may degrade the performance of the database.
