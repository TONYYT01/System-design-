### Linear Search

```python
class Solution:
    def Linear_Search(self,nums,tar):
        n=len(nums)
        for i in range(n):
            if nums[i]==tar:
                return i
        return -1
print(Solution().Linear_Search([1,3,4,8,9,10,11],1))
```