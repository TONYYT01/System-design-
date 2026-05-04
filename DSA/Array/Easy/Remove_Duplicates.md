### Remove duplicates in array


### Brute force

```python
class Solution:
    def Remove_Dupliates(self,nums):
        n=len(nums)
        uni=[]
        for i in range(n):
            if nums[i] not in uni:
                uni.append(nums[i])
        return uni
print(Solution().Remove_Dupliates([1,1,2,2,2,3,3]))
```

### Optimal

```python
class Solution:
    def Remove_Duplicates(self,nums):
        n=len(nums)
        i=0
        for j in range(1,n):
            if nums[i]!=nums[j]:
                nums[i+1]=nums[j]
                i+=1
        return nums[:i+1]
print(Solution().Remove_Duplicates([1,1,2,2,2,3,3]))
```