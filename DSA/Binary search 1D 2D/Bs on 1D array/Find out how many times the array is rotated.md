Given an integer array nums of size n, sorted in ascending order with distinct values. The array has been right rotated an unknown number of times, between 0 and n-1 (including). Determine the number of rotations performed on the array.


Example 1

Input : nums = [4, 5, 6, 7, 0, 1, 2, 3]

Output: 4

Explanation: The original array should be [0, 1, 2, 3, 4, 5, 6, 7]. So, we can notice that the array has been rotated 4 times.

Example 2

Input: nums = [3, 4, 5, 1, 2]

Output: 3

Explanation: The original array should be [1, 2, 3, 4, 5]. So, we can notice that the array has been rotated 3 times.

```python
class Solution:
    def findKRotation(self, nums):
        low=0
        high=len(nums)-1
        index=-1
        ans=float("inf")
        while low<=high:
            mid=(low+high)//2
            if nums[low]<=nums[high]:
                if nums[low]<ans:
                    ans=nums[low]
                    index=low
                break
            if nums[low]<=nums[mid]:
                if nums[low]<ans:
                    ans=nums[low]
                    index=low
                low=mid+1
            else:
                if nums[mid]<ans:
                    ans=nums[mid]
                    index=mid
                high=mid-1
        return index
```