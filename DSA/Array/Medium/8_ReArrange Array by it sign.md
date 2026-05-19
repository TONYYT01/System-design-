### Rearrange the array by it sign 

- This one states we have to rearrange the array by its signs

```python
[1,2,-2,-5,-5,9]
```
- We have to rearrange it sign like one plus and another one -

```python
[1,-2,2,-5,9,-5]
```

#### Optimal one

```python
class Solution:
    def rearrangeArray(self, nums):
        even=0
        odd=1
        num=[0]*len(nums)
        for i in range(len(nums)):
            if nums[i]>0:
                num[even]=nums[i]
                even+=2
            else:
                num[odd]=nums[i]
                odd+=2
        return num
print(Solution().rearrangeArray([3,5,-3,-4,9,-2]))
```

- Tc -> O(n)
- Sc -> O(n)
