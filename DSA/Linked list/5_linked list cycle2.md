```python
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, x):
#         self.val = x
#         self.next = None

class Solution:
    def hasCycle(self, head: Optional[ListNode]) -> bool:
        dic={}
        temp=head
        while (temp!=None):
            if temp in dic:
                return temp
            dic[temp]=1
            temp=temp.next
        return False
````