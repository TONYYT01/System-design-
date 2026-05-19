### Leaders in an array

#### Brute force

```python
class Solution:
    def leaders(self, nums):
        k=[]
        for i in range(len(nums)):
            isgrater=True
            for j in range(i+1,len(nums)):
                if nums[j]>nums[i]:
                    isgrater=False
            if isgrater:
                k.append(nums[i])
        return k
print(Solution().leaders([1,20,22,12,0,3,6]))
```

#### Optimal

```python
class Solution:
    def Leaders_in_Array(self,nums):
        k=[]
        maxi=nums[len(nums)-1]
        k.append(maxi)
        for i in range(len(nums)-1,-1,-1):
            if nums[i]>maxi:
                k.append(nums[i])
                maxi=nums[i]
        return k[::-1]
print(Solution().Leaders_in_Array([1,20,22,12,0,3,6]))
```