- Given an array of intervals where intervals[i] = [starti, endi], merge all overlapping intervals and return an array of the non-overlapping intervals that cover all the intervals in the input.
- You can return the intervals in any order.


> Example 1

Input: intervals = [[1,5],[3,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Intervals [1,5] and [3,6] overlap, so they are merged into [1,6].

> Example 2

Input: intervals = [[5,7],[1,3],[4,6],[8,10]]
Output: [[1,3],[4,7],[8,10]]
Explanation: Intervals [4,6] and [5,7] overlap and are merged into [4,7].


### optimal

- Sort and check with the other numbers whather they are in tha correct and update them

```python
class Solution:
    def Mearge_intervels(self,nums):
        n=len(nums)
        ans=[]
        nums.sort()
        for i in range(n):
            start=nums[i][0]
            end=nums[i][1]
            if (len(ans)!=0 and end<=ans[-1][1]):
                continue
            for j in range(i+1,n):
                if nums[j][0]<=end :
                    end=max(end,nums[j][1])
                else:
                    break
            ans.append([start,end]) 
        return ans
print(Solution().Mearge_intervels(  [[5,7],[1,3],[4,6],[8,10]]))
```