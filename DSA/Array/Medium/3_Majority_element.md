### Find the majority Element in an array

### Better one

```python
class Solution:
    def Majority_element(self,nums):
        read={}
        for i in nums:
            if i in read:
                read[i]+=1
            else:
                read[i]=1
        majority=len(nums)//2
        for k,v in read.items():
            if v>majority:
                return k
        return 0
print(Solution().Majority_element([1,2,1,1,1,2,1]))

```