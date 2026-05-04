### We have to rotate the array by k places


```python
class Solution:
    def Rotate_Array_k_places(self,nums,k):
        k%=len(nums)
        temp=[0]*k
        for i in range(k):
            temp[i]=nums[i]
        for i in range(k,len(nums)):
            nums[i-k]=nums[i]
        j=0
        for i in range (len(nums)-k,len(nums)):
            nums[i]=temp[j]
            j+=1
        return nums
print(Solution().Rotate_Array_k_places([1,2,3,4,5],3))
```