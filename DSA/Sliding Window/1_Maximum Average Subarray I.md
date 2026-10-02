## Maximum Average Subarray I


You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
Example 2:

Input: nums = [5], k = 1
Output: 5.00000

```python
# 1 2 3 4 5
        l=0
        n=len(nums)
        ans=0
        window=0
        for i in range(k):
            window+=nums[i]
        ans=window/k
        for r in range(k,n):
            window+=nums[r]-nums[r-k]
            ans=max(ans,window/k)
        return ans
```

```python
class Solution:
    def findMaxAverage(self, nums: list[int], k: int) -> float:
        current=sum(nums[:k])
        ans=current

        for i in range(k,len(nums)):
            current=current-nums[i-k]+nums[i]
            if current>ans :
                ans=current
        return ans/k
```