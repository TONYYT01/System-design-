Given an array nums sorted in non-decreasing order. Every number in the array except one appears twice. Find the single number in the array.


Example 1

Input :nums = [1, 1, 2, 2, 3, 3, 4, 5, 5, 6, 6]

Output:4

Explanation: Only the number 4 appears once in the array.

Example 2

Input : nums = [1, 1, 3, 5, 5]

Output:3

Explanation: Only the number 3 appears once in the array.

### Brute force

```python
class Solution:
    def singleNonDuplicate(self, nums):
        k={}
        for i in range(len(nums)):
            if nums[i] in k:
                k[nums[i]]+=1
            else:
                k[nums[i]]=1
        for key,value in k.items():
            if value==1:
                return key
        return -1
```