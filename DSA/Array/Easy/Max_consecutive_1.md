### Maximum consecutive 1's

```python
class Solution:
    def Max_consecutive(self,nums):
        n=len(nums)
        Count_1=0
        larcount=0
        for i in range(n):
            if nums[i]==1:
                Count_1+=1
            else:
                if Count_1>larcount:
                    larcount=Count_1
                    Count_1=0
                Count_1=0
        if Count_1>larcount:
            larcount=Count_1
        return larcount
print(Solution().Max_consecutive([1, 0, 1, 1, 0, 1]))
```