## Maximum Nesting Depth of the Parentheses

A string s is a valid parentheses string (VPS) if it meets the following conditions:

It only contains digits 0-9, arithmetic operators +, -, *, /, and parentheses (, ).
The parentheses are balanced and correctly nested.


Your task is to compute the maximum nesting depth of parentheses in s. The nesting depth is the highest number of parentheses that are open at the same time at any point in the string.


Example 1

Input: s = "(1+(2*3)+((8)/4))+1"

Output: 3

Explanation: The deepest nested sub-expression is ((8)/4), which has 3 layers of parentheses.



Example 2

Input: s = "(1)+((2))+(((3)))"

Output: 3

Explanation: The digit '3' is enclosed in 3 pairs of parentheses.

```python
class Solution:
    def maxDepth(self, s: str) -> int:
        res=0
        count=0
        for i in s:
            if i=="(":
                count+=1
                res=max(count,res)
            elif i==")":
                count-=1
                res=max(count,res)
        return res
print(Solution().maxDepth("(1+(2*3)+((8)/4))+1"))
```