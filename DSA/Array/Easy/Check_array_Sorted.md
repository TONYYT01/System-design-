### We have to find the if the array is sorted are not

```python
class Solution:
    def Check_Sorted(self,nums):
        n=len(nums)
        for i in range(1,n):
            if nums[i]>=nums[i-1]:
                continue
            else:
                return False
        return True
print(Solution().Check_Sorted([45,2,3,45,]))
```