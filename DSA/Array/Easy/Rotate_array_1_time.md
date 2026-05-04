#### Rotate array by 1 time

```python
class Solution:
    def Roate_Array_1_time(self,nums):
        n=len(nums)
        a=nums[0]
        for i in range(1,n):
            nums[i-1]=nums[i]
        nums[n-1]=a
        return nums
print(Solution().Roate_Array_1_time([1,2,3,4,5]))
```