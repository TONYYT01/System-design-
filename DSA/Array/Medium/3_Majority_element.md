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

### Optimal

```python
class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        el=0
        c=0
        for i in range(len(nums)):
            if c==0:
                c=1
                el=nums[i]
            elif nums[i]==el:
                c+=1
            else:
                c-=1
        c1=0
        for i in range(len(nums)):
            if el==nums[i]:
                c1+=1
        if c1> len(nums)//2:
            return el
        return -1
```