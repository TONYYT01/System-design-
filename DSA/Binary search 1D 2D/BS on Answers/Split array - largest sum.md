Given an integer array a of size n and an integer k. Split the array a into k non-empty subarrays such that the largest sum of any subarray is minimized. Return the minimized largest sum of the split.


Example 1

Input: a = [1, 2, 3, 4, 5], k = 3

Output:6

Explanation: There are many ways to split the array a[] into k consecutive subarrays. The best way to do this is to split the array a[] into [1, 2, 3], [4], and [5], where the largest sum among the three subarrays is only 6.

Example 2

Input: a = [3,5,1], k = 3

Output: 5

Explanation: There is only one way to split the array a[] into 3 subarrays, i.e., [3], [5], and [1]. The largest sum among these subarrays is 5.

```python
class Solution:
    def allocate(self,nums,mid,k):
            alloc=1
            pages=0
            for i in range(len(nums)):
                if nums[i]>mid:
                    return False
                if pages+nums[i]>mid:
                    alloc+=1
                    pages=nums[i]
                else:
                    pages+=nums[i]
            return alloc<=k
    def splitArray(self, nums: List[int], k: int) -> int:
        low=min(nums)
        high=sum(nums)
        ans=-1
        while low<=high:
            mid=(low+high)//2
            if self.allocate(nums,mid,k):
                ans=mid
                high=mid-1
            else:
                low=mid+1
        return ans
```