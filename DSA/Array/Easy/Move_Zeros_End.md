### Move zeros to the end

```python
class Solution:
    def Move_Zeros(self,nums):
        n=len(nums)
        j=0
        for i in range(n):
            if nums[i]!=0:
                nums[i],nums[j]=nums[j],nums[i]
                j+=1
        return nums
print(Solution().Move_Zeros([0,1,0,2,3,0]))
```