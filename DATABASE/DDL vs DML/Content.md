# DDL vs DML

In SQL, commands are grouped into categories based on what they do.  
Two important categories are:

- **Data Definition Language (DDL)**
- **Data Manipulation Language (DML)**

---

## a. Data Definition Language (DDL)

**DDL (Data Definition Language)** is used to define, create, or modify the **structure** of database objects such as tables, indexes, and views.

### Common DDL Commands

- `CREATE`
- `ALTER`
- `DROP`
- `TRUNCATE`

👉 **Key Idea:**  
DDL changes the **schema (design)** of the database, not the data itself.

👉 **Examples:**

```sql
CREATE TABLE students (
    id INT,
    name VARCHAR(50)
);

ALTER TABLE students ADD age INT;

DROP TABLE students;

TRUNCATE TABLE students;
```

👉 **Intuition:**  
DDL = *Changing the shape of the table*

---

## b. Data Manipulation Language (DML)

**DML (Data Manipulation Language)** is used to interact with the **data inside tables**.

### Common DML Commands

- `SELECT`
- `INSERT`
- `UPDATE`
- `DELETE`

👉 **Key Idea:**  
DML works with the data inside tables, without changing the structure.

👉 **Examples:**

```sql
INSERT INTO students VALUES (1, 'Rohan', 20);

SELECT * FROM students;

UPDATE students SET age = 21 WHERE id = 1;

DELETE FROM students WHERE id = 1;
```

👉 **Intuition:**  
DML = *Changing the data inside the table*

---

# The House and Furniture Analogy 🏠

Understanding this difference is easier with a real-world analogy:

## 🏗️ DDL → Architect & Builder

DDL is like designing and constructing a house.

- Building a new room → `CREATE`
- Modifying a room → `ALTER`
- Demolishing the house → `DROP`

👉 You are changing the **structure of the house**.

---

## 🛋️ DML → Resident

DML is like living inside the house.

- Adding furniture → `INSERT`
- Replacing furniture → `UPDATE`
- Removing items → `DELETE`

👉 You are changing the **contents**, not the structure.

---

# Quick Comparison

| Feature | DDL | DML |
|--------|-----|-----|
| Full Form | Data Definition Language | Data Manipulation Language |
| Purpose | Defines structure | Works with data |
| Affects | Tables, schema | Rows (records) |
| Commands | CREATE, ALTER, DROP, TRUNCATE | SELECT, INSERT, UPDATE, DELETE |
| Focus | Structure | Data |

---

# Final Takeaway

- **DDL** → Changes how the database is built  
- **DML** → Changes what’s inside the database  

Mess this up, and you’ll either:
- accidentally delete your structure 😬  
- or wonder why your data isn’t changing  

Choose wisely.