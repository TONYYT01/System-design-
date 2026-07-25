Given a 0-indexed n x m matrix mat where no two adjacent cells are equal, find any peak element mat[i][j] and return the array [i, j].A peak element in a 2D grid is an element that is strictly greater than all of its adjacent neighbours to the left, right, top, and bottom.



Assume that the entire matrix is surrounded by an outer perimeter with the value -1 in each cell.



Note: As there can be many peak values, 1 is given as output if the returned index is a peak number, otherwise 0.


Example 1

Input: mat=[[10, 20, 15], [21, 30, 14], [7, 16, 32]]

Output: [1, 1]

Explanation: The value at index [1, 1] is 30, which is a peak element because all its neighbours are smaller or equal to it. Similarly, {2, 2} can also be picked as a peak.

Example 2

Input: mat=[[10, 7], [11, 17]]

Output : [1, 1]

Explanation:The value at index [1, 1] is 17, which is the only peak element because all its neighbours are smaller or equal to it.

```python
class Solution:
    def findPeakGrid(self, mat: List[List[int]]) -> List[int]:
        n=len(mat)
        m=len(mat[0])
        for i in range(n):
            for j in range(m):
                istrue=True
                if i>0 and mat[i][j]<=mat[i-1][j]:
                    istrue=False
                if i<n-1 and mat[i][j]<=mat[i+1][j]:
                    istrue=False
                if j>0 and mat[i][j]<=mat[i][j-1]:
                    istrue=False
                if j<m-1 and mat[i][j]<=mat[i][j+1]:
                    istrue=False
                if istrue:
                    return [i,j]
        return [-1,-1]
```