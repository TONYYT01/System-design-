Given two sorted arrays arr1 and arr2 of size m and n respectively, return the median of the two sorted arrays.



The median is defined as the middle value of a sorted list of numbers. In case the length of the list is even, the median is the average of the two middle elements.


Example 1

Input: arr1 = [2, 4, 6], arr2 = [1, 3, 5]

Output: 3.5

Explanation: The array after merging arr1 and arr2 will be [ 1, 2, 3, 4, 5, 6 ]. As the length of the merged list is even, the median is the average of the two middle elements. Here two medians are 3 and 4. So the median will be the average of 3 and 4, which is 3.5.

Example 2

Input: arr1 = [2, 4, 6], arr2 = [1, 3]

Output: 3.0

Explanation: The array after merging arr1 and arr2 will be [ 1, 2, 3, 4, 6 ]. The median is simply 3.


```python
class Solution:
    def median(self, arr1, arr2):
        i=0
        j=0
        m=len(arr1)
        n=len(arr2)
        prev=curr=0
        for _ in range(((m+n)//2)+1):
            prev=curr
            if i < m and (j>=n or arr1[i]<=arr2[j]):
                curr=arr1[i]
                i+=1
            else:
                curr=arr2[j]
                j+=1
        if (m+n)%2==1:
            return curr
        return (prev+curr)/2
```