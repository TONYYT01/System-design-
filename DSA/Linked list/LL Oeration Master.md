1. Length of Linked List 
2. Search an element
3. Insert at Head
4. Insert at Tail
5. Insert at any Position
6. Delete Head
7. Delete Tail 
8. Delete at any Position

### 1. Length of Linked 

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
first=Node(10)
second=Node(20)
third=Node(30)

first.next=second
second.next=third

temp=first
count=0

while temp:
    count+=1
    temp=temp.next
print(count)
```
## 2.  Search an element
```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Solve(target):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    temp=first
    while temp:
        if temp.data==target:
            return True
        temp=temp.next
    return False
print(Solve(10))
```

## 3. Insert at Head

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Insert_Head(head,data):
    new_node=Node(data)
    new_node.next=head
    head=new_node
    return head
def Solve(value):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Insert_Head(head,value)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve(5)
```

## Interview Question
- What is the time complexity of insert_head()?

- How many nodes do we visit?
    - None
- We just change two references.
    - Time Complexity
        - O(1)
    - Space Complexity
        - O(1)

## 4. Insert at Tail

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Insert_Tail(head,data):
    new_node=Node(data)
    if head is None:
        return new_node
    temp=head
    while temp.next:
        temp=temp.next
    temp.next=new_node
    return head
def Solve(value):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Insert_Tail(head,value)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve(5)
```
## 5. Insert at any Position

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Insert_Any(head,data,pos):
    if pos==1:
        new_node=Node(data)
        new_node.next=head
        return new_node
    temp=head
    for i in range(pos-2):
        if temp.next==None:
            return head
        temp=temp.next
    new_node=Node(data)
    new_node.next=temp.next
    temp.next=new_node
    return head
def Solve(value,pos):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Insert_Any(head,value,pos)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve(5,2)
```

### 6 Delete Head

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Delete_Head(head):
    if head is None:
        return head
    head=head.next
    return head
def Solve():
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Delete_Head(head)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve()
```

### 7. Delete Tail

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Delete_Tail(head):
    if head is None:
        return None
    if head.next is None:
        return None
    temp=head
    while temp.next.next:
        temp=temp.next
    temp.next=None
    return head
def Solve():
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Delete_Tail(head)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve()
```

### 8. Delete at any Position

```python
class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Delete_Any(head,pos):
    if head is None:
        return None
    if pos==1:
        return head.next
    temp=head
    for i in range(pos-2):
        if temp.next is None:
            return head
        temp=temp.next
    temp.next=temp.next.next
    return head
def Solve(pos):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Delete_Any(head,pos)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve(30)
```