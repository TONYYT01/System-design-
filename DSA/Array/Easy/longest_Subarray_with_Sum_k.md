### Longest subarray with sum k

- it means the contigous part of the array 

## Bruteforce

```python
class Solution:
    def Longest_subarray_Sum_k(slef,nums,target):
        n=len(nums)
        le=0
        for i in range(n):
            s=0
            for j in range(i,n):
                s+=nums[j]
                if s==target:
                    le=max(le,j-i+1)
        return le
print(Solution().Longest_subarray_Sum_k([-3, 2, 1],6))
```
  
- 2 Pointers
- Gready method  
### Optimal

```python
class Solution:
    def Longest_subarray_sum(self,nums,k):
        n=len(nums)
        left=0
        right=0
        sum=nums[0]
        maxlen=0
        while right<n:
            while (left <=right and sum>k):
                sum-=nums[left]
                left+=1
            if sum==k:
                maxlen=max(maxlen,right-left+1)
            right+=1
            if (right<n):
                sum+=nums[right]
        return maxlen
print(Solution().Longest_subarray_sum([10, 5, 2, 7, 1, 9],15))
```