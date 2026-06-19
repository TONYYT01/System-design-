Lower Bound
Easy

Hints
Company
Given a sorted array of nums and an integer x, write a program to find the lower bound of x.



The lower bound algorithm finds the first and smallest index in a sorted array where the value at that index is greater than or equal to a given key i.e. x.



If no such index is found, return the size of the array.


Example 1

Input : nums= [1,2,2,3], x = 2

Output: 1

Explanation:

Index 1 is the smallest index such that arr[1] >= x.

### Brute force

```python
class Solution:
    def lowerBound(self, nums, x):
        n=len(nums)
        for i in range(n):
            if nums[i]>=x:
                return i
        return len(nums)
print(Solution().lowerBound([-58210,52968,57654,84387],89401))
```

### Optimal

```python
class Solution:
    def Lower_bound(self,nums,x):
        n=len(nums)
        ans=n
        low=0
        high=n-1
        while low<=high:
            mid=(low+high)//2
            if nums[mid]>=x:
                ans=mid
                high=mid-1
            else:
                low=mid+1
        return ans
print(Solution().Lower_bound([1,2,3,4,5,7],6))

```