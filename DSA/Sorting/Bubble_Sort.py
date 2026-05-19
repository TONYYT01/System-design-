class Solution:
    def Bubble_Sort(self,nums):
        for i in range(len(nums)-1):
            for j in range(len(nums)-i-1):
                if nums[j]>nums[j+1]:
                    nums[j],nums[j+1]=nums[j+1],nums[j]
        return nums
print(Solution().Bubble_Sort([9,7,1,2,3]))