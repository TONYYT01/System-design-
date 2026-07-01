## Reverse words in a given string / Palindrome Check

Given an input string, containing upper-case and lower-case letters, digits, and spaces( ' ' ). A word is defined as a sequence of non-space characters. The words in s are separated by at least one space.



Return a string with the words in reverse order, concatenated by a single space.


Example 1

Input: s = "welcome to the jungle"



Output: "jungle the to welcome"



Explanation: The words in the input string are "welcome", "to", "the", and "jungle". Reversing the order of these words gives "jungle", "the", "to", and "welcome". The output string should have exactly one space between each word.

Example 2

Input: s = " amazing coding skills "



Output: "skills coding amazing"



Explanation: The input string has leading and trailing spaces, as well as multiple spaces between the words "amazing", "coding", and "skills". After trimming the leading and trailing spaces and reducing the multiple spaces between words to a single space, the words are "amazing", "coding", and "skills". Reversing the order of these words gives "skills", "coding", and "amazing". The output string should not have any leading or trailing spaces and should have exactly one space between each word.


### Way 1
```python
class Solution:
    def Reverse_word(self,s):
        s=s[::-1]
        ans=""
        i=0
        while i<len(s):
            word=""
            while (i<len(s) and s[i]!=" "):
                word+=s[i]
                i+=1
            word=word[::-1]
            if len(word)>0:
                ans+=" "+word
            i+=1
        return ans.strip()
print(Solution().Reverse_word("   Naveen   KOla"))
```

### way 2

```python
class Solution:
    def Reverse_word(self,s):
        s=s.strip()
        s=s.split()
        s.reverse()
        return " ".join(s)
print(Solution().Reverse_word("   Naveen   KOla"))
```