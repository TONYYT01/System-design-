### Minimum Number of Days to Make m Bouquets
Given n roses and an array nums where nums[i] denotes that the 'ith' rose will bloom on the nums[i]th day, only adjacent bloomed roses can be picked to make a bouquet. Exactly k adjacent bloomed roses are required to make a single bouquet. Find the minimum number of days required to make at least m bouquets, each containing k roses. Return -1 if it is not possible.


Example 1

Input: n = 8, nums = [7, 7, 7, 7, 13, 11, 12, 7], m = 2, k = 3

Output: 12

Explanation: On the 12th the first 4 flowers and the last 3 flowers would have already bloomed. So, we can easily make 2 bouquets, one with the first 3 and another with the last 3 flowers.

Example 2

Input: n = 5, nums = [1, 10, 3, 10, 2], m = 3, k = 2

Output: -1

Explanation: If we want to make 3 bouquets of 2 flowers each, we need at least 6 flowers. But we are given only 5 flowers, so, we cannot make the bouquets.

Example 3

Input: n = 5, nums = [1, 10, 3, 10, 2], m = 3, k = 1

Output:

3

### Brute force

```python
class Solution:
    def Possible(self,nums,day,m,k):
        count=0
        no_of=0
        for i in ranage(len(nums)):
            if nums[i]<=day:
                count+=1
            else:
                no_of+=(count//k)
                count=0
        no_of+=(count//k)
        if no_of>=m:
            return True
        else:
            return False
    def minDays(self, bloomDay: List[int], m: int, k: int) -> int:
        if (len(bloomDay)<(m*k)):
            return -1
        for i in range(min(bloomDay),max(bloomDay)+1):
            if (self.Possible(bloomDay,i,m,k)==True):
                return i
        return -1
```

### Optimal

```python
class Solution:
    def Possible(self,nums,day,m,k):
        count=0
        no_of=0
        for i in range(len(nums)):
            if nums[i]<=day:
                count+=1
            else:
                no_of+=(count//k)
                count=0
        no_of+=(count//k)
        if no_of>=m:
            return True
        else:
            return False
    def minDays(self, bloomDay: List[int], m: int, k: int) -> int:
        if (len(bloomDay)<(m*k)):
            return -1
        low=min(bloomDay)
        high=max(bloomDay)
        ans=high
        while (low<=high):
            mid=(low+high)//2
            if (self.Possible(bloomDay,mid,m,k)==True):

                ans=mid
                high=mid-1
            else:
                low=mid+1
        return ans
```
