## Koko Eating Bananas

Koko loves to eat bananas. There are n piles of bananas, the ith pile has piles[i] bananas. The guards have gone and will come back in h hours.

Koko can decide her bananas-per-hour eating speed of k. Each hour, she chooses some pile of bananas and eats k bananas from that pile. If the pile has less than k bananas, she eats all of them instead and will not eat any more bananas during this hour.

Koko likes to eat slowly but still wants to finish eating all the bananas before the guards return.

Return the minimum integer k such that she can eat all the bananas within h hours.

 

Example 1:

Input: piles = [3,6,7,11], h = 8
Output: 4
Example 2:

Input: piles = [30,11,23,4,20], h = 5
Output: 30
Example 3:

Input: piles = [30,11,23,4,20], h = 6
Output: 23

### Brute force

```python
class Solution:
    def time_cal(self,piles,bananas):
        total_time=0
        for i in range(len(piles)):
            total_time+=(piles[i]+bananas-1)//bananas
        return total_time
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        for i in range(1,max(piles)+1):
            freq=self.time_cal(piles,i)
            if freq<=h:
                return i
```

### Optimal

```python
class Solution:
    def Maxi(self,nums):
        maxi=float("-inf")
        for i in range(len(nums)):
            if nums[i]>maxi:
                maxi=nums[i]
        return maxi
    def cal_time(self,nums,bana):
        total=0
        for i in range(len(nums)):
            total+=(nums[i]+bana-1)//bana
        return total
    def minEatingSpeed(self, piles: List[int], h: int) -> int:
        low=1
        high=self.Maxi(piles)
        ans=float("inf")
        while (low<=high):
            mid=(low+high)//2
            freq=self.cal_time(piles,mid)
            if freq<=h:
                ans=mid
                high=mid-1
            else:
                low=mid+1
        return ans
```