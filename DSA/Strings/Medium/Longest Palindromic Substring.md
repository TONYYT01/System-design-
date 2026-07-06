## Longest Palindromic Substring

Given a string s, return the longest palindromic substring in s.

 

Example 1:

Input: s = "babad"
Output: "bab"
Explanation: "aba" is also a valid answer.
Example 2:

Input: s = "cbbd"
Output: "bb"

```python
class Solution:
    def Longest(self,s):
        longest=0
        ans=""
        if len(s)==1 or s==s[::-1]:
            return s
        for i in range(len(s)):
            l,r=i,i
            ## Odd length
            while l>=0 and r<len(s) and s[l]==s[r]:
                if r-l+1>longest:
                    ans=s[l:r+1]
                    longest=r-l+1
                l-=1
                r+=1
            ### Even length
            l,r=i,i+1
            while  l>=0 and r<len(s) and s[l]==s[r]:
                if l-r+1 >longest:
                    longest=r-l+1
                    ans=s[l:r+1]
            l-=1
            r+=1
        return ans
print(Solution().Longest("babad"))
```

