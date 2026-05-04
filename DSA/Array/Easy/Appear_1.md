### numbers in array appear at 1's other twise

```python
class Solution:
    def Appears_1(self,nums):
        d={}
        n=len(nums)
        for i in range(n):
            if nums[i] in d:
                d[nums[i]]+=1
            else:
                d[nums[i]]=1
        for k,v in d.items():
            if v==1:
                return k
print(Solution().Appears_1([1, 2, 2, 4, 3, 1, 4]))
```