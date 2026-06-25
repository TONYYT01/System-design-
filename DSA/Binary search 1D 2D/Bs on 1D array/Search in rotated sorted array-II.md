Example 1:

Input Format: arr = [7, 8, 1, 2, 3, 3, 3, 4, 5, 6], k = 3

Result: True

Explanation: The element 3 is present in the array. So, the answer is True.

Example 2:

Input Format: arr = [7, 8, 1, 2, 3, 3, 3, 4, 5, 6], k = 10

Result: False

Explanation: The element 10 is not present in the array. So, the answer is False.

### Brute force

- Linear search

### Optimal one

```python
class Solution:
    def searchInARotatedSortedArrayII(self, nums, k):
        n=len(nums)
        low=0
        high=n-1
        while low<=high:
            mid=(low+high)//2
            if nums[mid]==k:
                return True
            if nums[low]==nums[mid]==nums[high]:
                low=low+1
                high=high-1
                continue
            if nums[low]<=nums[mid]:
                if nums[low]<=k<=nums[mid]:
                    high=mid-1
                else:
                    low=mid+1
            else:
                if nums[mid]<=k<=nums[high]:
                    low=mid+1
                else:
                    high=mid-1
        return False
```