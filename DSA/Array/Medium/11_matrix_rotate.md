### Rotate the matrix in the 90 degrees or Rotate the image

- We need to rotate the array by the 90 degree in the clock wise direction

![image.png](https://assets.leetcode.com/users/images/f474f92d-18e5-4b6d-9ad6-1be4e62f6a24_1779206074.5808363.png)

### Brute force

```python
class Solution:
    def Rotate_90(self,matrix):
        n=len(matrix)
        m=len(matrix[0])
        ans=[[0]*m for _ in range(n)]
        for i in range(n):
            for j in range(m):
                ans[j][n-1-i]=matrix[i][j]
        return ans
print(Solution().Rotate_90([[0,1,2],[0,2,3],[9,8,2]]))
```

### Optimal

1. Transpose the matrix
    1. change the columns are row 
    2. rows are columns
2. reverse the every row

```python
class Solution:
    def Rotate(self,nums):
        n=len(nums)
        for i in range(n-1):
            for j in range(i+1,n):
                nums[i][j],nums[j][i]=nums[j][i],nums[i][j]
        for i in range(n):
            nums[i].reverse()
        return nums
print(Solution().Rotate([[0,1,2],[0,2,3],[9,8,2]]))
```


