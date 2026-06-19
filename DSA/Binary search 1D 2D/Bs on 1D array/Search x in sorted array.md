Given a sorted array of integers nums with 0-based indexing, find the index of a specified target integer. If the target is found in the array, return its index. If the target is not found, return -1.


Example 1

Input: nums = [-1,0,3,5,9,12], target = 9

Output: 4

Explanation: The target integer 9 exists in nums and its index is 4

# Linear search
## Brute force

```python
class Solution:
    def Search_x(self,nums,target):
        n=len(nums)
        for i in range(n):
            if nums[i]==target:
                return i
        return -1
print(Solution().Search_x([-1,0,4,5,9,10],9))a
```


# Binary search

### Opimal 

```python
class Solution:
    def Search_x(slef,nums,target):
        low=0
        high=len(nums)-1
        while (low<=high):
            mid=(low+high)//2
            if nums[mid]==target:
                return mid
            elif nums[mid]<target:
                low=mid+1
            elif nums[mid]>target:
                high=mid-1
        return -1
print(Solution().Search_x([-1,0,4,5,9,10],9))
```