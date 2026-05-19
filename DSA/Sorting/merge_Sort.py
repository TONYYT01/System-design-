class Solution:
    def Merge(self,nums,low,mid,high):
        temp=[]
        left=low
        right=mid+1
        while(left<=mid and right<=high):
            if nums[left]<=nums[right]:
                temp.append(nums[left])
                left+=1
            else:
                temp.append(nums[right])
                right+=1
        while (left<=mid):
            temp.append(nums[left])
            left+=1
        while(right<=high):
            temp.append(nums[right])
            right+=1
        k=0
        for i in range(low,high+1):
            nums[i]=temp[k]
            k+=1
    def Ms(self,nums,low,high):
        if low>=high:
            return 
        mid=(low+high)//2
        self.Ms(nums,low,mid)
        self.Ms(nums,mid+1,high)
        self.Merge(nums,low,mid,high)
    def Merge_Sort(self,nums,n):
        self.Ms(nums,0,n-1)
        return nums
n=int(input())
nums=list(map(int,input().split(",")))
print(Solution().Merge_Sort(nums,n))