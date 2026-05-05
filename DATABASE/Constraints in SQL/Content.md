# Constraints in SQL

- Constraints are used to specify rules for the data in a table. If there is any violation between the constraint and the data action, the action is aborted. This ensures the accuracy and reliability of the data within the table.

--------

### A. AUTO_INCREMENT

- The AUTO_INCREMENT constraint allows a unique number to be generated automatically when a new record is inserted into a table. This is most commonly used for Primary Key columns so you do not have to manually track the next ID number.

```sql
create table if not exists Users(
  User_id int primary key AUTO_INCREMENT,
  User_Name varchar(30),
  Email varchar(30),
  Date_of_birth date,
  Gender varchar(20)
)
show tables;
insert into Users(User_Name,Email)
values("Naveen","Naveen123@gmail.com");
```
### B. NOT NULL

- By default, a column can hold NULL values. The NOT NULL constraint enforces a column to always contain a value. This means you cannot insert a new record or update a record without adding a value to this field.

```sql
create table if not exists Users (
  User_id int primary key auto_increment,
  User_Name varchar(20) not null,
  Email varchar(20) not null,
  Gender varchar(20),
  Age int
)
```
- When i insert the data it won't return the error because i satisify the constraints of it correctly

```sql
insert into Users(User_Name,Email,Age)
values("Naveen_2005","Kola123@gmail.com",23);
```

- If incase i entred the data like this means

```sql
insert into Users(User_Name,Gender,Age)
values("Naveen_2005","Male",23);
```

- Error
```sql
There is problem

field "Email" doesn't have the default value
```

### C. UNIQUE

- The UNIQUE constraint ensures that all values in a column are different. This is perfect for columns like email addresses, phone numbers, or usernames where you want to prevent two people from having the same identity.

```sql
create table if not exists Users (
  User_id int primary key auto_increment,
  User_Name varchar(20) not null,
  Email varchar(20) not null Unique,
  Gender varchar(20),
  Age int
)
```

```sql
insert into Users(User_Name,Email,Age)
values("Naveen_2005","Kola123@gmail.com",23);
```
- If incase again i entred the same email it through the error like this 

```sql
There was a problem 

Duplicate entry "kola123@gmail.com" for key "User.Email"
```
- It means we are entering the duplicate value to the column email

### D. CHECK

- The CHECK constraint is used to limit the value range that can be placed in a column. If you define a CHECK constraint on a column, it will allow only certain values.

`Example:` Enforce a rule that users must be between 15 and 30 years old to join a specific batch. 

```sql
create table if not exists Users (
  User_id int primary key auto_increment,
  User_Name varchar(20) not null,
  Email varchar(20) not null Unique,
  Gender varchar(20),
  Age int not null check (Age>=18 and Age<=30)
)
```
- If incase i entred the data in different ways it 

##### Way 1

```sql
insert into Users(User_Name,Email,Age)
values("Naveen_2005","Kola123@gmail.com",23);
```
##### Way 2

```sql
insert into Users(User_Name,Email,Age)
values("Kola_2005","Naveen123@gmail.com",17);
```
`Error` 
```sql
There was a problem
Check constraint "User_check_1" is violated.
```

### E. DEFAULT

- The DEFAULT constraint is used to set a default value for a column. The default value will be added to all new records if no other value is specified.

```sql
create table if not exists Users (
  User_id int primary key auto_increment,
  User_Name varchar(20) not null unique,
  Email varchar(20) not null Unique,
  Gender varchar(20),
  Age int not null check (Age>=18 and Age<=30),
  is_active boolean default true
)

```
- After i entred the data

```sql
insert into Users(User_Name,Email,Age)
values("Kola_2005","Naveen123@gmail.com",18);
```

| User_id (int) | User_Name (varchar(20)) | Email (varchar(20)) | Gender (varchar(20)) | Age (int) | is_active (tinyint(1)) |
|---------------|------------------------|--------------------|----------------------|-----------|------------------------|
| 1             | Kola_2005              | Naveen123@gmail.com| NULL                 | 18        | 1                      |
