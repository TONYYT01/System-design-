# What is an Index in a Database?

An **index** in a database is a special data structure (usually a B-tree or similar) that helps make searching faster.

Instead of scanning every row, the database uses the index to **jump directly to the required data**, similar to a book index.

---

# 📚 Book Analogy

- ❌ No index → You flip through pages → **Slow**
- ✅ With index → Jump directly to page → **Fast**

👉 In databases:
- No index → **Full Table Scan**
- With index → **Index Lookup**

---

# How Indexing Works Internally

When you create an index:

The database creates a hidden **mini-table** containing:

1. **Sorted values of the column**
2. **Pointers to actual rows**

👉 Because it's sorted, the database uses **Binary Search**

- Instead of checking 1,000,000 rows  
- It might check ~20 steps  

👉 **Big speed upgrade**

---

# Practical Scenario: Users Table

### Table: `users`

| user_id | full_name     | email              | city      |
|--------|--------------|-------------------|-----------|
| 1      | Raj Patel    | raj@test.com       | Mumbai    |
| 2      | Neha Gupta   | neha@test.com      | Delhi     |
| ...    | ...          | ...                | ...       |
| 99999  | Amit Sharma  | amit@sample.org    | Bengaluru |

---

# Case 1: Searching (Huge Performance Difference)

## ❌ Without Index

```sql
SELECT * FROM users WHERE email = 'amit@sample.org';
```

- Checks row by row  
- Time complexity → **O(n)**  
- Very slow  

---

## ✅ With Index

```sql
CREATE INDEX idx_user_email ON users(email);

SELECT * FROM users WHERE email = 'amit@sample.org';
```

### Result:

| user_id | full_name    | email             | city      |
|--------|-------------|------------------|-----------|
| 99999  | Amit Sharma | amit@sample.org  | Bengaluru |

👉 Database jumps directly to the correct row.

---

# Case 2: Sorting (ORDER BY)

Indexes also help with sorting.

```sql
CREATE INDEX idx_user_name ON users(full_name);

SELECT full_name, email
FROM users
ORDER BY full_name;
```

### Result:

| full_name    | email             |
|-------------|------------------|
| Amit Sharma | amit@sample.org  |
| Neha Gupta  | neha@test.com    |
| Raj Patel   | raj@test.com     |

👉 Data is already sorted in the index → no extra work.

---

# Case 3: Composite Index (Multiple Columns)

When filtering on multiple columns:

```sql
CREATE INDEX idx_name_city ON users(full_name, city);

SELECT *
FROM users
WHERE full_name = 'Raj Patel'
AND city = 'Mumbai';
```

### Result:

| user_id | full_name | email         | city   |
|--------|----------|--------------|--------|
| 1      | Raj Patel| raj@test.com | Mumbai |

👉 Faster because both columns are indexed together.

---

# ⚠️ The Hidden Cost of Indexing

Indexes improve **read speed**, but hurt **write performance**.

### Every time you:
- `INSERT`
- `UPDATE`
- `DELETE`

👉 Database must:
1. Update table  
2. Update ALL indexes  

👉 More indexes = slower writes  

---

# Summary: Full Scan vs Index

| Feature | Full Table Scan | Index Lookup |
|--------|----------------|-------------|
| Search Speed | Slow (Linear) | Fast (Logarithmic) |
| Disk Space | No extra space | Uses extra space |
| Insert Speed | Fast | Slower |
| Best For | Small tables | Large tables |

---

# Common Mistakes to Avoid

## ❌ Indexing Low-Selectivity Columns
Example: `gender`

👉 Only few values → index is useless  

---

## ❌ Over-Indexing

Too many indexes =  
- slower writes  
- heavy system  

---

## ❌ Indexing Frequently Updated Columns

Example: `last_seen`

👉 Constant updates → high load  

---

## ❌ Not Using EXPLAIN

```sql
EXPLAIN SELECT ...
```

👉 Always check:
- Is index actually used?

---

# Final Takeaway

- Index = **speed booster for reads**
- But = **cost for writes**

👉 Smart developers:
- Index what matters  
- Ignore what doesn’t  

---

Mess this up and:
- Your queries crawl 🐢  
- Or your inserts cry 😭  

Balance is everything.