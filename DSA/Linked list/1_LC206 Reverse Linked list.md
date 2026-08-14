Reverse a LL

Given the head of a singly linked list. Reverse the given linked list and return the head of the modified list.


Example 1

Input: head -> 1 -> 2 -> 3 -> 4 -> 5

Output: head -> 5 -> 4 -> 3 -> 2 -> 1

Explanation: All the links are reversed and the head now points to the last node of the original list.

Example 2

Input: head -> 6 -> 8

Output: head -> 8 -> 6

Explanation: All the links are reversed and the head now points to the last node of the original list.

This can be seen like: 6 <- 8 <- head.

### Bruete force

```python
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        temp=head
        data=[]
        while temp!=None:
            data.append(temp.val)
            temp=temp.next
        temp=head
        while temp!=None:
            temp.val=data.pop()
            temp=temp.next
        return head
```