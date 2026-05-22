# SQL Query Lifecycle (Parse → Plan → Execute)

When you run a SQL query, the database internally follows three major steps:

1. **Parse**
2. **Plan**
3. **Execute**

You don’t directly control these steps, but understanding them is key for performance and optimization.

---

# The Database's Internal Thought Process 🍕

Think of ordering a pizza:

- **Parse** → Understand your request  
- **Plan** → Decide how to prepare it  
- **Execute** → Cook and deliver  

Databases work the same way.

---

# Source Data

### Table: `customers`

| customer_id | name  | email            | city   | signup_at_utc       |
|------------|------|------------------|--------|---------------------|
| 101        | Aisha | aisha@demo.com  | Delhi  | 2026-01-01 10:00:00 |
| 102        | Rohan | rohan@demo.com  | Mumbai | 2026-01-02 11:00:00 |
| 103        | Meera | meera@demo.com  | Pune   | 2026-01-03 12:00:00 |
| 104        | Arjun | arjun@demo.com  | Delhi  | 2026-01-04 13:00:00 |

---

# 1. Parse (Understanding the Request)

Parsing checks if your SQL is:
- syntactically correct
- semantically valid

### What the database checks:

- SQL grammar (SELECT, FROM, WHERE)
- Table existence
- Column existence
- Data type compatibility

👉 **If anything is wrong → query fails immediately**

👉 **Intuition:**  
Parse = *"Can I understand this request?"*

---

## ✅ Scenario 1: Valid Query

```sql
SELECT name, email
FROM customers
WHERE city = 'Mumbai';
```

✔ Checks pass:
- valid syntax  
- table exists  
- columns exist  

---

## ❌ Scenario 2: Syntax Error (Missing FROM)

```sql
SELECT name, email
customers
WHERE city = 'Mumbai';
```

❌ Error:
```
syntax error near 'customers'
```

---

## ❌ Scenario 3: Semantic Error (Wrong Column)

```sql
SELECT full_name, email
FROM customers
WHERE city = 'Mumbai';
```

❌ Error:
```
unknown column 'full_name'
```

---

# 2. Plan (Query Optimization)

Planning decides the **best way to execute the query**.

This is handled by the **Query Optimizer**.

### It decides:

- Whether to use indexes
- Table join order
- Full table scan vs index scan
- Memory allocation

👉 Output = **Execution Plan**

👉 **Intuition:**  
Plan = *"What is the fastest way to get this?"*

---

## Scenario 1: Filtering with Index

```sql
SELECT name, email
FROM customers
WHERE city = 'Mumbai';
```

### Planning Logic:

- If index on `city` exists → fast lookup  
- If not → full table scan (slow)

---

## Scenario 2: Sorting with Index

```sql
SELECT name, signup_at_utc
FROM customers
ORDER BY signup_at_utc ASC;
```

### Planning Logic:

- If index exists → already sorted → fast  
- If not → sort in memory/disk → slow  

---

# 3. Execute (Doing the Work)

Execution is where the database **actually runs the plan**.

### What happens:

- Reads data from disk/memory  
- Applies filters  
- Performs joins  
- Sorts / aggregates  
- Returns results  

👉 **Intuition:**  
Execute = *"Now actually do the work."*

---

## Scenario 1: Data Retrieval

```sql
SELECT name, email
FROM customers
WHERE city = 'Mumbai';
```

### Result:

| name  | email           |
|------|-----------------|
| Rohan | rohan@demo.com |

### Execution Flow:

- Using index → jump directly to row  
- Without index → scan all rows  

---

## Scenario 2: Aggregation

```sql
SELECT COUNT(*) AS delhi_customers
FROM customers
WHERE city = 'Delhi';
```

### Result:

| delhi_customers |
|----------------|
| 2              |

### Execution Flow:

- Find rows where city = Delhi  
- Count them  
- Return result  

---

# Common Mistakes to Avoid

## ❌ Ignoring Parse Errors
If parsing fails → nothing runs  
👉 Fix syntax first

---

## ❌ Not Understanding Slow Queries
Slow queries usually mean **bad planning**

👉 Use:
```sql
EXPLAIN SELECT ...
```

---

## ❌ Thinking SQL is Step-by-Step

SQL is **declarative**, not procedural.

👉 You say:
> "What you want"

👉 Database decides:
> "How to get it"

---

# Final Takeaway

| Stage   | Meaning |
|--------|--------|
| Parse  | Validate query |
| Plan   | Optimize strategy |
| Execute| Run query |

---

If your query fails → problem in **Parse**  
If your query is slow → problem in **Plan**  
If your query runs → that's **Execute**

---

Mess this up, and you’ll either:
- write queries that don’t run 😵  
- or queries that run like a potato 🐢  

Choose wisely.