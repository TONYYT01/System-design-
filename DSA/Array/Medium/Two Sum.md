### Find  the two sum

##### Brute force

```python
class Solution:
    def TwoSum(self,nums,target):
        n=len(nums)
        for i in range(n):
            for j in range(i+1,n):
                if nums[i]+nums[j]==target:
                    return i,j,"Yes"
    
        return "No"
print(Solution().TwoSum([1,2,3,5,5],8))
```
- T.C -> O(n^2)

##### Better

```python
class Solution:
    def TwoSum(self,nums,target):
        dict={}
        n=len(nums)
        for i in range(n):
            a=nums[i]
            more=target-a
            if more in dict :
                return "Yes"
            dict[a]=i
        return "NO"
print(Solution().TwoSum([1,2,3,4,5],10))
```

- If you return in the list

```python
class Solution:
    def twoSum(self, nums, target):
        n=len(nums)
        d={}
        k=[0,0]
        for i in range(n):
            a=nums[i]
            more = target-a
            if more in d:
                k[0]=d[more]
                k[1]=i
                return k
            d[a]=i
        return [-1,-1]
```