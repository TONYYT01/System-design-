class Solution:
    def Roman_TO_integer(self,s):
        k={"I":1,"V":5,"X":10,"C":100,"D":500,"M":1000}

        res=0
        for i in range(len(s)):
            if i+1  <len(s) and k[s[i]]<k[s[i+1]]:
                res-=k[s[i]]
            else:
                res+=k[s[i]]
        return res
print(Solution().Roman_TO_integer("IX"))