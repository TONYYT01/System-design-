### Find the missing number in array

```python
class Solution:
    def Find_missing(self,nums):
        l=len(nums)
        numbers=[]
        for i in range(l+1):
            numbers.append(i)
        for i in numbers:
            if i not in nums:
                return i
        return -1
print(Solution().Find_missing([0, 1, 2, 4, 5, 6]))
```