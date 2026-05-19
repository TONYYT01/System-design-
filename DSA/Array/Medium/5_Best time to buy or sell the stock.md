### Best time to buy and sell the stock

#### Optimal one
- In Dp there are totally 6 questions
- 1 question is this one

```python
class Solution:
    def Stock_Buy_Sell(self,nums):
        profit=0
        mini=nums[0]
        n=len(nums)
        for i in range(1,n):
            cost=nums[i]-mini
            profit=max(profit,cost)
            mini=min(mini,nums[i])
        return profit
print(Solution().Stock_Buy_Sell([7,1,5,3,6,4]))
```