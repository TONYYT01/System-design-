### String to Integer (atoi)

Implement the function myAtoi(s) which converts the given string s to a 32-bit signed integer (similar to the C/C++ atoi function).



Steps to Implement:

First, ignore any leading whitespace characters ' ' until the first non-whitespace character is found.
Check the next character to determine the sign. If it’s a '-', the number should be negative. If it’s a '+', the number should be positive. If neither is found, assume the number is positive.
Read the digits and convert them into a number. Stop reading once a non-digit character is encountered or the end of the string is reached. Leading zeros should be ignored during conversion.
The result should be clamped within the 32-bit signed integer range: [-2147483648, 2147483647]. If the computed number is outside this range, return -2147483648 if the number is less than -2147483648, or return 2147483647 if the number is greater than 2147483647.
Finally, return the computed number after applying all the above steps.

Example 1

Input: s = " -12345"

Output: -12345

Explanation:

Ignore leading whitespaces.
The sign '-' is encountered, indicating the number is negative.
Digits 12345 are read and converted to -12345.
Example 2

Input: s = "4193 with words"

Output: 4193

Explanation:

Read the digits 4193 and stop when encountering the first non-digit character (w).

```python
class Solution:
    def myAtoi(self, s):
        sign=1
        num=0
        i=0
        n=len(s)
        while i<n and s[i]==" ":
            i+=1
        if i<n and s[i] in ["+" ,"-"]:
            if s[i]=="-":
                sign=-1
            i+=1
        while i<n and s[i].isdigit():
            num=num*10 +int(s[i])
            i+=1
        num*=sign
        int_max=2**31-1
        int_min=-2**31
        if num>int_max:
            return int_max
        if num<int_min:
            return int_min
        return num
print(Solution().myAtoi("-1234"))
```