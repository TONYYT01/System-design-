### Find the largest element in the array

```python
class Solution:
    def Largest(self,nums):
        largest=nums[0]
        n=len(nums)
        for i in range(n):
            if nums[i] >largest:
                largest=nums[i]
        return largest
print(Solution().Largest([1,1000,4,5,7]))
```