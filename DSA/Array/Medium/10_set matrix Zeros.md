### Set matrix has zero

### Brute force
![image.png](https://assets.leetcode.com/users/images/4c278017-8cf1-4969-97b2-8ac647fd6716_1779190452.8450644.png)

![image.png](https://assets.leetcode.com/users/images/4289d97b-e489-4a85-87c5-69c2cf0804ac_1779190442.2867496.png)

![image.png](https://assets.leetcode.com/users/images/6ae930b3-7d49-47a3-b93c-40a97e43f718_1779190706.9246566.png)

![image.png](https://assets.leetcode.com/users/images/c4a8de1c-2785-4a10-a96d-60b39b0e8dfb_1779190733.046168.png)


### Better

![image.png](https://assets.leetcode.com/users/images/bf1447fd-bdd9-4440-b833-1348ab99b133_1779191224.9557526.png)

![image.png](https://assets.leetcode.com/users/images/779b21fb-8f91-449c-ae01-5d59d8cca398_1779191231.8875086.png)

![image.png](https://assets.leetcode.com/users/images/87515b42-75d6-4b8e-9fd2-4b20185d58da_1779191238.7644753.png)

```python
class Solution:
    def set_matrix0(self,matrix):
        n=len(matrix)
        m=len(matrix[0])
        row=[0]*n
        col=[0]*m
        for i in range(n):
            for j in range(m):
                if matrix[i][j]==0:
                    row[i]=1
                    col[j]=1
        for i in range(n):
            for j in range(m):
                if row[i]==1 or col[j]==1:
                    matrix[i][j]=0
        return matrix
print(Solution().set_matrix0([[1,1,1],[1,0,1],[1,1,1]]))
```