## Step 1: What is a Node?

- A linked list is made of nodes

- Each node has the 
    - Data
    - Address of the next node

- First node is called Head node
- Last node is called Tail node

```python
+-------+-------+
| data  | next  |
+-------+-------+
```

```python
10 -> 20 -> 30 -> None
```

## Creating Node

```python
class Node:
    def __init__(self, data):
        self.data = data
        self.next = None
```

```python
class Node:
    def __init__(self, data):
        self.data = data
        self.next = None

head = Node(10)

print(head.data)
```
### Creating 2 nodes
```python
first = Node(10)
second = Node(20)
```

## connect 

```python
first.next = second
```

```python
first
  |
  V
+------+------+
| 10   | ---- |------+
+------+------+
                    |
                    V
               +------+------+
               | 20   | None |
               +------+------+
```

## Access

```python
print(first.next.data)
```
## Why?
```python
first
  |
  V
Node(10)

first.next
     |
     V
Node(20)

first.next.data

20

```
## Creating 3 nodes

```python
first = Node(10)
second = Node(20)
third = Node(30)

first.next = second
second.next = third
```

```python
head
 |
 V
+----+-----+      +----+-----+      +----+------+
|10  |  *-------> |20  |  *-------> |30  | None |
+----+-----+      +----+-----+      +----+------+
```

```python
print(first.data)
print(first.next.data)
print(first.next.next.data)
```

### Traversing LL

```python
class Node:
    def __init__(self,Data):
        self.Data=Data
        self.next=None
first=Node(10)
second=Node(20)
third=Node(30)

first.next=second
second.next=third

print(first.Data)
print(first.next.Data)
print(first.next.next.Data)
```
## Using Loop

```python
class Node:
    def __init__(self,Data):
        self.Data=Data
        self.next=None
first=Node(10)
second=Node(20)
third=Node(30)

first.next=second
second.next=third

temp=first

while temp:
    print(temp.Data)
    temp=temp.next
``` 

```python
| Expression             | Result    |
| ---------------------- | --------- |
| `first`                | Node      |
| `first.data`           | `10`      |
| `first.next`           | Node (20) |
| `first.next.data`      | `20`      |
| `first.next.next`      | Node (30) |
| `first.next.next.data` | `30`      |
| `first.next.next.next` | `None`    |

```