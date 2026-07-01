### Anagram

Given two strings s and t, return true if t is an anagram of s, and false otherwise.



An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.


Example 1

Input : s = "anagram" , t = "nagaram"

Output : true

Explanation :

We can rearrange the characters of string s to get string t as frequency of all characters from both strings is same.

Example 2

Input : s = "dog" , t = "cat"

Output : false

Explanation :

We cannot rearrange the characters of string s to get string t as frequency of all characters from both strings is not same.



```python
class Solution:
    def Anagram(self,s,t):
        arr=[0]*26
        for i in range(len(s)):
            arr[ord(s[i])-ord("a")]+=1
            arr[ord(t[i])-ord("a")]-=1
        for i in arr:
            if i !=0:
                return False
        return True
print(Solution().Anagram("anagram","nagaram"))
```