- Given two integer arrays nums1 and nums2. Both arrays are sorted in non-decreasing order.
- Merge both the arrays into a single array sorted in non-decreasing order.
- The final sorted array should be stored inside the array nums1 and it should be done in-place.
- nums1 has a length of m + n, where the first m elements denote the elements of nums1 and rest are 0s.

- nums2 has a length of n.

> Example 1

- Input: nums1 = [-5, -2, 4, 5], nums2 = [-3, 1, 8]

- Output: [-5, -3, -2, 1, 4, 5, 8]

> Explanation:

- The merged array is: [-5, -3, -2, 1, 4, 5, 8], where [-5, -2, 4, 5] are from nums1 and [-3, 1, 8] are from nums2

### brute force
```python
class Solution:
    def merge(self, nums1,nums2):
        k=nums1+nums2
        k.sort()
        return k
print(Solution().merge([-5, -2, 4, 5],[-3, 1,8]))
```

```python
class Solution:
    def merge(self, nums1,m,nums2,n):
        nums1[:]=sorted(nums1[:m]+nums2[:n])
print(Solution().merge([-5, -2, 4, 5],4,[-3, 1,8],3))
```

### Better

```python
class Solution:
    def merge(self,num1,num2,m,n):
        ans=[0]*(m+n)
        left=0
        right=0
        index=0
        while left<m and right<n:
            if num1[left]<=num2[right]:
                ans[index]=num1[left]
                left+=1
                index+=1
            else:
                ans[index]=num2[right]
                right+=1
                index+=1
        while left<m:
            ans[index]=num1[left]
            index+=1
            left+=1
        while right<n:
            ans[index]=num2[right]
            index+=1
            right+=1
        return ans
print(Solution().merge( [-5, -2, 4, 5],[-3, 1, 8],4,3))
```