    Given a 2D array matrix where each row is sorted in ascending order from left to right and each column is sorted in ascending order from top to bottom, write an efficient algorithm to search for a specific integer target in the matrix.


Example 1

Input: matrix = [ [1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30] ], target = 5

Output: True

Explanation: The target 5 exists in the matrix in the index (1,1)

Example 2

Input: matrix= [ [1, 4, 7, 11, 15], [2, 5, 8, 12, 19], [3, 6, 9, 16, 22], [10, 13, 14, 17, 24], [18, 21, 23, 26, 30] ], target = 20

Output: False

Explanation: The target 20 does not exist in the matrix.

```python
class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        for num in matrix:
            low=0
            high=len(num)-1
            while low <= high:
                mid=(low+high)//2
                if num[mid]==target:
                    return True
                if num[mid]>target:
                    high=mid-1
                if num[mid]<target:
                    low=mid+1
        return False
```