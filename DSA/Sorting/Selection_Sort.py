class Solution:
    def Selection_Sort(self,nums):
        for i in range(len(nums)-1):
            min=i
            for j in range(i,len(nums)):
                if nums[min]>nums[j]:
                    min=j
            nums[i],nums[min]=nums[min],nums[i]
        return nums
print(Solution().Selection_Sort([9,8,1,2,3]))