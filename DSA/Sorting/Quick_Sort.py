class Solution:
    def Functi(self,nums,low,high):
        prvet=low
        i=low
        j=high
        while(i<j):
            while(nums[i]<=nums[prvet] and i<high):
                i+=1
            while (nums[j]>nums[prvet] and j>low):
                j-=1
                if i<j:
                    nums[i],nums[j]=nums[j],nums[i]
            nums[prvet],nums[j]=nums[j],nums[prvet]
            return j
    def Qs(self,nums,low,high):
        if low<high:
            prvt=self.Functi(nums,low,high)
            self.Qs(nums,low,prvt-1)
            self.Qs(nums,prvt+1,high)
    def Quick_sort(self,nums,n):
        self.Qs(nums,0,n-1)
        return nums
n=int(input())
nums=list(map(int,input().split(",")))
print(Solution().Quick_sort(nums,n))