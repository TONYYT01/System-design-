# Query Fundamentals in SQL

Once you understand what a database and SQL are, the next step is learning how to actually read data from your tables. In real projects, you’ll constantly ask questions like:

- “Which users signed up today?”
- “What are the top 10 highest-paying customers?”

Commands like `SELECT`, `FROM`, `WHERE`, logical operators (`AND`, `OR`, `NOT`), comparison operators, `ORDER BY`, `LIMIT`, `DISTINCT`, and `AS` (aliases) work together to help you:

- Pick the right rows
- Choose the right columns
- Present results in a clean and useful way

In this chapter, we’ll break down each of these step by step.

---

## At a High Level, a SQL Query Answers:

1. From which table do I want data?
2. Which columns do I want?
3. Which rows should I keep or discard?
4. In what order should I see the results?
5. Do I want all rows or just a few?

---
![Screenshot 2026-05-22 111130.png](https://assets.leetcode.com/users/images/03219914-a118-44d1-9755-d84fe56b2330_1779430400.2828634.png)


# Example Table: `countries`

We’ll use a real and relatable example throughout this chapter.

## Create Table

### MySQL

```sql
CREATE TABLE countries (
  id INT PRIMARY KEY AUTO_INCREMENT,
  country VARCHAR(64) NOT NULL,
  population BIGINT NULL,
  area INT NOT NULL,
  region VARCHAR(64) NOT NULL
);
```

### PostgreSQL

```sql
CREATE TABLE countries (
  id SERIAL PRIMARY KEY,
  country VARCHAR(64) NOT NULL,
  population BIGINT NULL,
  area INT NOT NULL,
  region VARCHAR(64) NOT NULL
);
```

---

## Insert Sample Data

```sql
INSERT INTO countries (country, population, area, region) VALUES
('India', 1400000000, 3287000, 'Asia'),
('China', 1200000000, 4287000, 'Asia'),
('Brazil', 214000000, 8516000, 'South America'),
('Australia', 25700000, 7692000, 'Oceania'),
('USA', 331000000, 9834000, 'North America');
```

---

## Sample Data Output

| id | country   | population | area    | region          |
|----|------------|------------|---------|-----------------|
| 1  | India      | 1400000000 | 3287000 | Asia            |
| 2  | China      | 1200000000 | 4287000 | Asia            |
| 3  | Brazil     | 214000000  | 8516000 | South America   |
| 4  | Australia  | 25700000   | 7692000 | Oceania         |
| 5  | USA        | 331000000  | 9834000 | North America   |

---

# 1. SELECT & FROM

`SELECT` specifies the columns you want to retrieve from a table.

Without `SELECT`, SQL doesn’t know what data you want to view.

`FROM` tells SQL which table to read data from.

---

## Select All Columns

```sql
SELECT *
FROM countries;
```

### Output

| id | country   | population | area    | region          |
|----|------------|------------|---------|-----------------|
| 1  | India      | 1400000000 | 3287000 | Asia            |
| 2  | China      | 1200000000 | 4287000 | Asia            |
| 3  | Brazil     | 214000000  | 8516000 | South America   |
| 4  | Australia  | 25700000   | 7692000 | Oceania         |
| 5  | USA        | 331000000  | 9834000 | North America   |

> Useful for exploring a new table, but in real projects, selecting only needed columns is better practice.

---

## Select Specific Columns

```sql
SELECT country, population
FROM countries;
```

### Output

| country   | population |
|------------|------------|
| India      | 1400000000 |
| China      | 1200000000 |
| Brazil     | 214000000  |
| Australia  | 25700000   |
| USA        | 331000000  |

Now the result is cleaner and more focused.

---

# 2. WHERE

`WHERE` filters rows based on conditions.

Only rows matching the condition are returned.

---

## Example: Find Countries in Oceania

```sql
SELECT *
FROM countries
WHERE region = 'Oceania';
```

### Output

| country   | population | area   | region   |
|------------|------------|--------|-----------|
| Australia  | 25700000   | 7692000 | Oceania |

`WHERE` decides which rows stay and which rows get discarded.

---

# 3. Comparison Operators

These operators are the foundation of filtering data.

| Operator | Meaning                     | Example |
|----------|-----------------------------|---------|
| `<`      | Less than                   | `population < 50000000` |
| `>`      | Greater than                | `salary > 30000` |
| `<=`     | Less than or equal to       | `age <= 18` |
| `>=`     | Greater than or equal to    | `marks >= 90` |
| `=`      | Equal to                    | `city = 'Delhi'` |
| `!=` or `<>` | Not equal to           | `status != 'active'` |

You’ll use these constantly while writing SQL queries.

---

# 4. Logical Operators

Logical operators combine or modify conditions inside a `WHERE` clause.

---

## a. AND

All conditions must be true.

### Example

Find countries where:

- population is greater than 50 million
- AND area is less than 5 million sq km

```sql
SELECT *
FROM countries
WHERE population > 50000000
  AND area < 5000000;
```

### Output

| country | population | area    | region |
|----------|------------|---------|--------|
| India    | 1400000000 | 3287000 | Asia   |
| China    | 1200000000 | 4287000 | Asia   |

---

## b. OR

At least one condition must be true.

### Example

Find countries located in Asia or Oceania.

```sql
SELECT *
FROM countries
WHERE region = 'Asia'
   OR region = 'Oceania';
```

### Output

| country   | population | area    | region   |
|------------|------------|---------|-----------|
| India      | 1400000000 | 3287000 | Asia      |
| China      | 1200000000 | 4287000 | Asia      |
| Australia  | 25700000   | 7692000 | Oceania   |

---

## c. NOT

Negates a condition.

### Example

Exclude countries from North America.

```sql
SELECT *
FROM countries
WHERE NOT region = 'North America';
```

### Output

| country   | population | area    | region          |
|------------|------------|---------|-----------------|
| India      | 1400000000 | 3287000 | Asia            |
| China      | 1200000000 | 4287000 | Asia            |
| Brazil     | 214000000  | 8516000 | South America   |
| Australia  | 25700000   | 7692000 | Oceania         |

---

# 5. Arithmetic Operators

Arithmetic operators perform mathematical calculations inside queries.

| Operator | Meaning | Example |
|----------|---------|---------|
| `+` | Addition | `SELECT 10 + 5 AS result;` |
| `-` | Subtraction | `SELECT 10 - 5 AS result;` |
| `*` | Multiplication | `SELECT 10 * 5 AS result;` |
| `/` | Division | `SELECT 10 / 5 AS result;` |
| `%` | Modulus (remainder) | `SELECT 10 % 3 AS remainder;` |
| `DIV` | Integer division (MySQL only) | `SELECT 7 DIV 2 AS quotient;` |

---

## Examples

### Addition

```sql
SELECT 10 + 5 AS result;
```

### Subtraction

```sql
SELECT 10 - 5 AS result;
```

### Multiplication

```sql
SELECT 10 * 5 AS result;
```

### Division

```sql
SELECT 10 / 5 AS result;
```

### Modulus

```sql
SELECT 10 % 3 AS remainder;
```

### Integer Division (MySQL Only)

```sql
SELECT 7 DIV 2 AS quotient;
```

---

# 6. ORDER BY & LIMIT

`ORDER BY` sorts rows.

- `ASC` → Ascending order (default)
- `DESC` → Descending order

`LIMIT` restricts the number of returned rows.

---

## Example: Top 2 Largest Countries by Area

```sql
SELECT country, area
FROM countries
ORDER BY area DESC
LIMIT 2;
```

### Output

| country | area    |
|----------|---------|
| USA      | 9834000 |
| Brazil   | 8516000 |

### What Happened?

1. Rows were sorted by `area`
2. Largest values came first because of `DESC`
3. `LIMIT 2` returned only the first two rows

Classic interview question energy right there.

---

# 7. DISTINCT & AS (Aliases)

## DISTINCT

`DISTINCT` removes duplicate values.

---

## AS (Alias)

`AS` gives temporary names to columns or tables.

Aliases improve readability without changing the database structure.

---

## Example: Unique Regions

```sql
SELECT DISTINCT region AS unique_region
FROM countries;
```

### Output

| unique_region |
|----------------|
| Asia |
| South America |
| Oceania |
| North America |

---

# Final Notes

These are the core building blocks of SQL querying.

If you master:

- `SELECT`
- `FROM`
- `WHERE`
- comparison operators
- logical operators
- `ORDER BY`
- `LIMIT`
- `DISTINCT`
- aliases

…you can already answer a shocking amount of real-world data questions.

Most beginners think SQL is massive and scary.

Reality?

It’s mostly learning how to ask data the right questions.

That’s it.

---

Source Content: :contentReference[oaicite:0]{index=0}