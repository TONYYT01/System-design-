### Longest Common Prefix

Write a function to find the longest common prefix string amongst an array of strings.



If there is no common prefix, return an empty string "".


Example 1

Input : str = ["flowers" , "flow" , "fly", "flight" ]

Output : "fl"

Explanation :

All strings given in array contains common prefix "fl".

Example 2

Input : str = ["dog" , "cat" , "animal", "monkey" ]

Output : ""

Explanation :

There is no common prefix among the given strings in array.


```python
class Solution:  
    def longestCommonPrefix(self, strs):
        #your code goes here 
        if len(strs)==1:
            return strs[0]
        res=""
        for i in range(len(strs[0])):
            for s in strs:
                if i==len(s) or s[i]!= strs[0][i]:
                    return res
            res+=strs[0][i]
        return res
        
```