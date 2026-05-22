# NULL vs 0 vs Empty String

## 1. What is NULL?

**NULL** means *"no value," "unknown," or "not applicable."*  
It is not zero, and it is not a blank piece of text.

Think of it like a blank space on a form where a value could be, but currently is not.

### Example: Middle Name Field

| id | first_name | middle_name | last_name |
|----|------------|-------------|-----------|
| 1  | Rohan      | NULL        | Sharma    |
| 2  | Ananya     | Kaur        | Singh     |

👉 **Intuition:**  
`NULL` means *"There is no value stored here."*

---

## 2. What is 0 (Zero)?

**0 (zero)** is a valid number.  
It represents a known value — specifically, *zero quantity*.

### Example: Orders Table

| order_id | product_name | quantity |
|----------|-------------|----------|
| 101      | Mouse       | 2        |
| 102      | Keyboard    | 0        |
| 103      | Monitor     | NULL     |

👉 **Explanation:**
- `0` → We **know** the quantity is zero.
- `NULL` → We **don’t know** the quantity.

👉 **Intuition:**  
`0` means *"We know the value, and it is exactly zero."*

---

## 3. What is an Empty String ('')?

An **empty string (`''`)** is a valid text value with **zero characters**.

It is different from:
- `NULL` → no value at all  
- `' '` → a string with one space  

### Example: User Nickname

| user_id | full_name    | nickname |
|---------|-------------|----------|
| 1       | Priya Verma | ''       |
| 2       | Aman Gupta  | 'AG'     |
| 3       | Rohan       | NULL     |

👉 **Explanation:**
- `''` → user intentionally left it blank  
- `NULL` → user never filled it  

👉 **Intuition:**  
`''` means *"We know the value, and it is an empty piece of text."*

---

# How These Differences Affect Queries

## Sample Data: inventory

| product  | stock_level | notes           |
|----------|------------|-----------------|
| Laptop   | 10         | 'In stock'      |
| Mouse    | 0          | 'Out of stock'  |
| Keyboard | NULL       | NULL            |
| Monitor  | 5          | ''              |

---

## Case 1: Filtering "Empty" vs "Unknown"

### Find products with no notes

```sql
-- Finds only empty strings
SELECT * FROM inventory WHERE notes = '';

-- Finds only NULL values
SELECT * FROM inventory WHERE notes IS NULL;
```

👉 **Important:**  
- `= ''` misses NULLs  
- `IS NULL` misses empty strings  

💡 **Pro Tip:** Use `COALESCE()` or `NULLIF()` to standardize values.

---

## Case 2: Impact on Aggregations

### Calculate average stock level

```sql
SELECT AVG(stock_level) AS average_stock
FROM inventory;
```

👉 **What happens internally:**
- Values used → `10 + 0 + 5`
- NULL is ignored
- Count = 3 (not 4)

👉 **Key Insight:**  
NULLs are **excluded**, zeros are **included**.

---

# Summary Comparison

| Concept | Meaning | How to Check | Impact on Math |
|--------|--------|-------------|---------------|
| NULL   | Missing/unknown data | `IS NULL` | Ignored in AVG(), SUM() |
| 0      | Known value = zero | `= 0` | Included in calculations |
| ''     | Known empty text | `= ''` | Not usable in math |

---

# Common Mistakes to Avoid

### ❌ Using `= NULL`
```sql
SELECT * FROM table WHERE column = NULL; -- WRONG
```

✔ Correct:
```sql
SELECT * FROM table WHERE column IS NULL;
```

---

### ❌ Confusing Empty String with NULL
- Some systems store blank inputs as `''`
- Others store them as `NULL`

👉 Always verify how your system behaves.

---

### ❌ Misusing COUNT()

```sql
COUNT(column_name) -- ignores NULLs
COUNT(*)           -- counts all rows
```

👉 Choose based on whether you want:
- total rows (`COUNT(*)`)
- only non-null values (`COUNT(column_name)`)

---

# Final Takeaway

- `NULL` → unknown / missing  
- `0` → known zero  
- `''` → known empty text  

Mess this up in real projects, and your analytics will lie to you. No exaggeration.