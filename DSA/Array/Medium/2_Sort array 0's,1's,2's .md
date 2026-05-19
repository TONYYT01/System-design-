## We have to sort the array in the 0's and the 1's and the 2's accordingly

#### Brute force

```python
class Solution:
    def Sort_0_1_2(self,nums):
        n=len(nums)
        result=[]
        for i in [0,1,2]:
            for j in range(n):
                if i==nums[j]:
                    result.append(nums[j])
        return result
print(Solution().Sort_0_1_2([0,1,0,1,2,1]))
```
- And also use the any of the sorting technique to get the result but the t.c is nlogn

- Above one T.C -> O(n^2)

### Better 

```python
class Solution:
    def Sort_0_1_2(self,nums):
        c1=0
        c2=0
        c3=0
        n=len(nums)
        for i in nums:
            if i == 0:
                c1+=1
            elif i==1:
                c2+=1
            elif i==2:
                c3+=1
        for i in range(c1):
            nums[i]=0
        for j in range(c1,c2+1):
            nums[j]=1
        for k in range(c2+c1,n):
            nums[k]=2
        return nums
print(Solution().Sort_0_1_2([1,0,1,2,1,0,2]))
```

### Optimal one 

- Duch national flag algorithm

![image.png](https://assets.leetcode.com/users/images/5bb9a978-8c5d-4687-b1a6-2efb2bfb45b4_1778223586.4128711.png)

![image.png](https://assets.leetcode.com/users/images/dc3e2809-efcb-43e8-8e72-0ba5e9882440_1778223623.5786097.png)

![image.png](https://assets.leetcode.com/users/images/cf5d67dc-45d7-4865-9c46-9125eb2357f8_1778223670.7025611.png)

![image.png](https://assets.leetcode.com/users/images/8d6abfd7-6ebd-415c-956d-f31b513f665a_1778223700.7987802.png)

```python
class Solution:
    def Sort_0_1_2(self,nums):
        low=0
        mid=0
        high=len(nums)-1
        while mid<=high:
            if nums[mid]==0:
                nums[low],nums[mid]=nums[mid],nums[low]
                low+=1
                mid+=1
            elif nums[mid]==1:
                mid+=1
            elif nums[mid]==2:
                nums[mid],nums[high]=nums[high],nums[mid]
                high-=1
        return nums
print(Solution().Sort_0_1_2([0,1,1,2,1,0]))
```
