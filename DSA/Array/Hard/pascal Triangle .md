### Pascal Triangle

- in this 3 types of problems we have 

1. They give r and c we need to print the element of that

- Example : r=5 and c=3 return 6  in a row 5 in the column 3 the element is 6 

```python

```
### Brute force
```python
class Solution:
    def Factorial(self,n):
        if n==1:
            return 1
        if n==0:
            return 2
        return n*self.Factorial(n-1)
    def Pascal_Triangle(self,n,c):
        n_fact=self.Factorial(n-1)
        d1=self.Factorial(c-1)
        d2=self.Factorial((n-1)-(c-1))
        return n_fact//(d1*d2)
print(Solution().Pascal_Triangle(5,3))
```

### Optimal one

```python
class Solution:
    def Pascal_triangle(self,r,c):
        r-=1
        c-=1
        res=1
        for i in range(c):
            res=(res)*(r-i)
            res=(res)//(i+1)
        return res
print(Solution().Pascal_triangle(5,3))
```

2. print the row of elements in the pascal trinagle n=6 print the 1 5 10 10 5 1


### Brute force
```python
class Solution:
    def element(self,r,c):
        res=1
        for i in range(c):
            res=(res)*(r-i)
            res=(res)//(i+1)
        return res
    def Pascal_triangle(self,n):
        for i in range(1,n):
            print(self.element(n-1,i-1),end=" ")
Solution().Pascal_triangle(5)
```

### Optimal one

```python
class Solution:
    def Pascal_triangle(self,n):
        ans=1
        print(ans,end=" ")
        for i in range(1,n):
            ans=(ans)*(n-i)
            ans=(ans)//(i)
            print(ans,end=" ")
Solution().Pascal_triangle(6)
```

3. return the pascal triangle in the form of lists

### Brute force

```python
class Solution:
    def element(self,n,r):
        ans=1
        for i in range(r):
            ans=(ans)*(n-i)
            ans=(ans)//(i+1)
        return ans
    def Pacal_triangle(self,num):
        ans=[]
        for i in range(num):
            temp=[]
            for j in range(i+1):
                temp.append(self.element(i,j))
            ans.append(temp)
        return ans
print(Solution().Pacal_triangle(6))
```
- T.C -> Near about O(n^3)

### Optimal one

```python
class Solution:
    def element(self,r,c):
        ans=1
        for i in range(c):
            ans=(ans)*(r-i)
            ans=(ans)//(i+1)
        return ans
    def Pascal_triangle(self,n):
        ans=[]
        for i in range(1,n+1):
            temp=[]
            for j in range(i):
                temp.append(self.element(i-1,j))
            ans.append(temp)
        return ans
print(Solution().Pascal_triangle(5))

```