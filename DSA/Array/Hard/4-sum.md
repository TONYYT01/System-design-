- Given an integer array nums and an integer target. Return all quadruplets [nums[a], nums[b], nums[c], nums[d]] such that:
- a, b, c, d are all distinct valid indices of nums.
- nums[a] + nums[b] + nums[c] + nums[d] == target.
- Notice that the solution set must not contain duplicate quadruplets. One element can be a part of multiple quadruplets. The output and the quadruplets can be returned in any order.

### Brute force

```python
class Solution:
    def Sum_4(self,nums,target):
        set1=set()
        n=len(nums)
        for i in range(n):
            for j in range(i+1,n):
                for k in range(j+1,n):
                    for l in range(k+1,n):
                        if nums[i]+nums[j]+nums[k]+nums[l]==target:
                            temp=sorted((nums[i],nums[j],nums[k],nums[l]))
                            set1.add(tuple(temp))
        ans=[list(x) for x in set1]
        return ans
print(Solution().Sum_4([1, -2, 3, 5, 7, 9],7))
```

### Better

```python
class Solution:
    def Sum_4(self,nums,target):
        n=len(nums)
        set1=set()
        for i in range(n):
            for j in range(i+1,n):
                set2=set()
                for k in range(j+1,n):
                    need=target-(nums[i]+nums[j]+nums[k])
                    if need in set2:
                        temp=sorted((nums[i],nums[j],nums[k],need))
                        set1.add(tuple(temp))
                    set2.add(nums[k])
        ans=[list(x) for x in set1]
        return ans
print(Solution().Sum_4([1, -2, 3, 5, 7, 9],7))     
```