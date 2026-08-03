Given the head of a singly linked list and an integer X, insert a node with value X at the head of the linked list and return the head of the modified list.


Example 1

Input: linkedList = [1, 2, 3], X = 7

Output: [7, 1, 2, 3]

Explanation:

7 was added as the 1st node.

Example 2

Input: linkedList = [], X = 7

Output: [7]

Explanation:

7 was added as the 1st node.

```python
# Definition of singly linked list:
# class ListNode:
#     def __init__(self, x=0, next=None):
#         self.data = x
#         self.next = next

class Solution:
    def insertAtHead(self, head, X):
      """
        :type head: Optional[ListNode]
        :type x: int
        :rtype: Optional[ListNode]
      """
      node=ListNode(X)
      node.next=head
      return node
```