Find Middle of Linked List
Easy

Given the head of a singly Linked List, return the middle node of the Linked List.



If the Linked List has an even number of nodes, return the second middle one.


Example 1

Input: head -> 3 -> 8 -> 7 -> 1 -> 3

Output(value at returned node): 7

Explanation: There are 5 nodes, so the middle node is the 3rd Node, with value 7.

Example 2

Input: head -> 2 -> 9 -> 1 -> 4 -> 0 -> 4

Output(value at returned node): 4

Explanation: There are 6 nodes, thus both the 3rd and 4th nodes are middle. So the 2nd middle node (4th Node) is returned with value 4.

```python
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def middleNode(self, head: Optional[ListNode]) -> Optional[ListNode]:
        temp=head
        count=0
        while temp!=None:
            count+=1
            temp=temp.next
        middle=(count//2)+1
        temp=head
        while temp!=None:
            middle-=1
            if middle==0:
                break
            temp=temp.next
        return temp
```