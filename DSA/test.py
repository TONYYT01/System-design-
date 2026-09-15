class Solution:
    def Stack(self):
        stack=[]
        
        while True:
            op=int(input("Enter the operation\n1. Peek\n2. push()\n3. pop()\n4. exit\n"))
            match(op):
                case 1:
                    if len(stack)<1:
                        print("Stack has no elements")
                    else:
                        print( stack[-1])
                case 2:
                    noOfEl=int(input("Enter the how many numbers to push : "))
                    for i in range(noOfEl):
                        data=int(input("Enter the element : "))
                        stack.append(data)
                    print(stack)
                case 3:
                    print(stack.pop() + "Removed")
                case 4 :
                    op=0
                    print("Bye!")
print(Solution().Stack())