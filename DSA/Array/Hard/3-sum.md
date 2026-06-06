## 3- Sum

- Given an integer array nums. Return all triplets such that:
- i != j, i != k, and j != k
- nums[i] + nums[j] + nums[k] == 0.
- Notice that the solution set must not contain duplicate triplets. One element can be a part of multiple triplets. The output and the triplets can be returned in any order.

#### Brute force 
- We take the 3 loops to each one ok solve this
```python
class Solution:
    def Sum_3(self,nums):
        data=set()
        for i in range(len(nums)):
            for j in range(i+1,len(nums)):
                for k in range(j+1,len(nums)):
                    if nums[i]+nums[j]+nums[k]==0:
                        temp=[nums[i],nums[j],nums[k]]
                        temp.sort()
                        data.add(tuple(temp))
        k=[list(x) for x in data]
        return k
print(Solution().Sum_3([8, -6, 5, 4]))
```

#### better

```python
class Solution:
    def threeSum(self, nums):
        set1=set()
        for i in range(len(nums)):
            set2=set()
            for j in range(i+1,len(nums)):
                k=-(nums[i]+nums[j])
                if k in set2:
                    temp=sorted((nums[i],nums[j],k))
                    set1.add(tuple(temp))
                set2.add(nums[j])
        ans=[list(x) for x in set1]
        return ans
```

### OPtimal
```python
class Solution:
    def Sum_3(self,nums):
        n=len(nums)
        ans=[]
        nums.sort()
        for i in range(n):
            if i>0 and nums[i]==nums[i-1]:
                continue
            j=i+1
            k=n-1
            while (j<k):
                Sum=nums[i]+nums[j]+nums[k]
                if Sum < 0:
                    j+=1
                elif Sum>0:
                    k-=1
                else:
                    temp=[nums[i],nums[j],nums[k]]
                    ans.append(temp)
                    j+=1
                    k-=1
                    while(j<k and nums[j]==nums[j-1]):
                        j+=1
                    while (j<k and nums[k]==nums[k+1]):
                        k-=1
        return ans
print(Solution().Sum_3([2, -2, 0, 3, -3, 5]))
```