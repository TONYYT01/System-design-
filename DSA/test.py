class Solution:
    def solve(self,nums):
        k=[]
        maxi=nums[len(nums)-1]
        k.append(maxi)
        for i in range(len(nums)-1,-1,-1):
                if nums[i]>maxi:
                    k.append(nums[i])
                    maxi=nums[i]
        return k[::-1]
print(Solution().solve([4,3,5,1,0]))