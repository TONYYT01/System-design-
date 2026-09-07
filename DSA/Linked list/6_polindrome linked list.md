## 234. Palindrome Linked List

Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

 ![alt text](image-3.png)

Input: head = [1,2,2,1]
Output: true

 ![alt text](image-4.png)

Input: head = [1,2]
Output: false

````python
# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        l=[]
        temp=head
        while temp!=None:
            l.append(temp.val)
            temp=temp.next
        temp=head
        while temp!=None:
            if temp.val!=l[-1]:
                return False
            temp=temp.next
            l.pop()
        return True
````