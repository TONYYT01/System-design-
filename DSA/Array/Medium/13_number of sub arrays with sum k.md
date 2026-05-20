### Number of sub arrays with sum k

### Better one 

```python
class Solution:
    def Number_Sub_Arrays(self,nums,k):
        n=len(nums)
        count=0
        for i in range(n):
            sum=0
            for j in range(i,n):
                sum+=nums[j]
                if sum==k:
                    count+=1
        return count
print(Solution().Number_Sub_Arrays([1,2,3,-3,1,1,1,4,2,-3],3))
```

### Optimal one
```python
class Solution:
    def Number_Sub_Arrays(self,nums,k):
        data={}
        data[0]=1
        prefix_sum=0
        count=0
        for i in range(len(nums)):
            prefix_sum+=nums[i]
            remove =prefix_sum-k
            count+=data.get(remove,0)
            data[prefix_sum]=data.get(prefix_sum,0)+1
        return count
print(Solution().Number_Sub_Arrays([1,2,3,-3,1,1,1,4,2,-3],3))
```