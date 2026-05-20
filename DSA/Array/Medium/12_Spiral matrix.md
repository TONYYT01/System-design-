### Sprial matrix

![image.png](https://assets.leetcode.com/users/images/4b0af846-88b4-46f6-a805-d7bb137d503d_1779258053.9655488.png)

![image.png](https://assets.leetcode.com/users/images/995fdeb7-6694-49cd-b59d-2c5e5b0c2c0f_1779258062.4071593.png)

- This problem has only the optimal one
- Interviewr is see the how you implement this code
- how clean you are writing the code

> Right -> Bottom -> Left -> Top

##### Optimal one

```python
class Solution:
    def Spiral_matrix(self,matrix):
        n=len(matrix)
        m=len(matrix[0])
        left=0
        right=m-1
        top=0
        bottom=n-1
        ans=[]
        while left<=right and top<=bottom:
            for i in range(left,right+1):
                ans.append(matrix[top][i])
            top+=1
            for i in range(top,bottom+1):
                ans.append(matrix[i][right])
            right-=1
            if top<=bottom:
                for i in range(right,left-1,-1):
                    ans.append(matrix[bottom][i])
                bottom-=1
            if left<=right:      
                for i in range(bottom,top-1,-1):
                    ans.append(matrix[i][left])
                left+=1
        return ans
print(Solution().Spiral_matrix([[1, 2, 3], [4, 5, 6], [7, 8, 9]]))
```