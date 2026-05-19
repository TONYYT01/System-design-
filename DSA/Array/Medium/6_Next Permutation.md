### Find the next Next permutation

####  Brute force

- Generate the all permutation
- Linear search
- Next find

```python

```

#### Better
- IN C++ we have the STL so to print the next permutation so easy to find that

#### Optimal
1. Longest prefix match
  1. a[i] < a[i+1]
2. Find the > 1 but the smallest one
  2. So that you stay close
3. Try to place in the remain in sorted order

```python
 class Solution:
    def Next_Permutation(self,nums):
        index=-1
        n=len(nums)
        for i in range(n-2,-1,-1):
            if nums[i]<nums[i+1]:
                index=i
                break
        if index!=-1:
            for i in range(n-1,index,-1):
                if nums[index]<nums[i]:
                    nums[i],nums[index]=nums[index],nums[i]
                    break
        nums[index+1:]=reversed(nums[index+1:])
        return nums
print(Solution().Next_Permutation([2,1,5,4,3,0,0]))
```