### Union of 2 sorted arrays

```python
class Solution:
    def union_2_Sorted_Array(self,A1,A2):
        n1=len(A1)
        n2=len(A2)
        i=0
        j=0
        union=[]
        while i<n1 and j<n2:
            if (A1[i]<=A2[j]):
                if len(union)==0 or A1[i]!=union[-1]:
                    union.append(A1[i])
                i+=1
            else:
                if len(union)==0 or A2[j]!=union[-1]:
                    union.append(A2[j])
                j+=1
        while j<n2:
            if len(union)==0 or A2[j]!=union[-1]:
                union.append(A2[j])
            j+=1
        while i<n1:
            if len(union)==0 or A1[i]!=union[-1]:
                union.append(A1[i])
            i+=1
        return union
print(Solution().union_2_Sorted_Array([1,1,2,3,4],[1,1,3,4,5,6]))
```