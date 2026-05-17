### We have print the maximum sub array sum

##### Brute force

```python
class Solution:
    def Maximum(self,nums):
        maxi=float("-inf")
        Sum=0
        n=len(nums)
        for i in range(n):
            Sum=0
            for j in range(i,n):
                Sum+=nums[j]
                if Sum>maxi:
                    maxi=Sum
        return maxi
print(Solution().Maximum([-2,-3,4,-1,-2,1,5,-3]))
```

#### Optimal one

`Kadane's Algorithem`

```python
class Solution:
    def Maximum_subArray(self,nums):
        maxi=float("-inf")
        sum=0
        n=len(nums)
        for i in range(n):
            sum+=nums[i]
            if sum<0:
                sum=0
            if sum>maxi:
                maxi=sum
        return maxi
print(Solution().Maximum_subArray([-2,-3,4,-1,-2,1,5,-3]))
```
- Tc -> O(n)
- Sc -> O(1)

#### Attached question

- Print that maximum subarray

```python
class Solution:
    def Maximum_subArray(self,nums):
        maxi=float("-inf")
        sum=0
        ansstart=-1
        ansend=-1
        n=len(nums)
        for i in range(n):
            if sum==0:
                start=i
            sum+=nums[i]
            if sum>maxi:
                maxi=sum
                ansstart=start
                ansend=i
            if sum<0:
                sum=0
        return nums[ansstart:ansend+1]
print(Solution().Maximum_subArray([-2,-3,4,-1,-2,1,5,-3]))
```