### We need to find the elements that appear in the n/3 times

- Given an integer array nums of size n. Return all elements which appear more than n/3 times in the array. The output can be returned in any order.


```python
class Solution:
    def Majority(self,nums):
        length=len(nums)
        k={}
        for i in nums:
            if i in k :
                k[i]+=1
            else:
                k[i]=1
        cal =len(nums)//3
        values=[]
        for val,key in k.items():
            if key>cal:
                values.append(val)
        return values
print(Solution().Majority([1, 2, 1, 1, 3, 2, 2]))
```