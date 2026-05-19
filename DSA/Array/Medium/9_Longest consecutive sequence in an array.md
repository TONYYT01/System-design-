### Longest consecutive sequence in an array

#### Brute force

```python
class Solution:
    def Longest_Consecutive(self,nums):
        largest=0
        n=len(nums)
        for i in range(n):
            x=nums[i]
            count=1
            for i in range(n):
                if x+1 in nums:
                    count+=1
                    x+=1
                else:
                    largest=max(largest,count)
        return largest
print(Solution().Longest_Consecutive([102,4,100,1,101,3,2,1,103,105,106,104])) 
```

#### Better

```python
class Solution:
    def Longest_consecutive(self,nums):
        longest=0
        current_count=1
        lastsmaller=float("-inf")
        nums.sort()
        n=len(nums)
        for i in range(n):
            if nums[i]-1==lastsmaller:
                current_count+=1
                lastsmaller=nums[i]
            elif nums[i]!=lastsmaller:
                current_count=1
                lastsmaller=nums[i]
            longest=max(longest,current_count)
        return longest

print(Solution().Longest_consecutive([102,4,100,1,101,3,2,1,103,105,106,104]))
```

### Optimal

```python
class Solution:
    def Longest_consecutive(self,nums):
        longest=0
        sets=set(nums)
        for num in sets:
            if num-1 in sets:
                continue
            count=1
            while num+1 in sets:
                num+=1
                count+=1
            longest=max(longest,count)
        return longest
print(Solution().Longest_consecutive([100,4,200,1,3,2]))
```