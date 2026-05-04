### Find the second largest number

```python
class Solution:
    def Seclargest(self,nums):
        sec=float("-inf")
        largest=float("-inf")
        n=len(nums)
        for i in range(n):
            if nums[i]>largest:
                sec=largest
                largest=nums[i]
            elif nums[i]>0 and nums[i]!=largest:
                sec=nums[i]
        return sec
print(Solution().Seclargest([1,3,4,11,789,11,789]))
```