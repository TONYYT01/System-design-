### Sum of Beauty of All Substrings

The beauty of a string is the difference in frequencies between the most frequent and least frequent characters.

For example, the beauty of "abaacc" is 3 - 1 = 2.
Given a string s, return the sum of beauty of all of its substrings.

 

Example 1:

Input: s = "aabcb"

Output: 5

Explanation: The substrings with non-zero beauty are ["aab","aabc","aabcb","abcb","bcb"], each with beauty equal to 1.

Example 2:

Input: s = "aabcbaa"

Output: 17

```python
class Solution:
    def Beauty(self,s):
        count=0
        n=len(s)
        for i in range(n):
            k={}
            for j in range(i,n):
                char=s[j]
                k[char]=k.get(char,0)+1
                freq=k.values()
                count+=max(freq)-min(freq)
        return count
print(Solution().Beauty("aabcb"))
```