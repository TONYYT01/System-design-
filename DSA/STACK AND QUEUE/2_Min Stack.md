## Min Stack

Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

Implement the MinStack class:

MinStack() initializes the stack object.
void push(int value) pushes the element value onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
You must implement a solution with O(1) time complexity for each function.

 

Example 1:

Input
["MinStack","push","push","push","getMin","pop","top","getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null,null,null,null,-3,null,0,-2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2
 

```python
class MinStack:

    def __init__(self):
        self.k=[]
    def push(self, value: int) -> None:
        if len(self.k)==0:
            self.k.append([value,value])
        else:
            self.k.append([value,min(value,self.k[-1][1])])
    def pop(self) -> None:
        self.k.pop()
    def top(self) -> int:
        if len(self.k)==0:
            return None
        else:
            return self.k[-1][0]
    def getMin(self) -> int:
        return self.k[-1][1]

# Your MinStack object will be instantiated and called as such:
# obj = MinStack()
# obj.push(value)
# obj.pop()
# param_3 = obj.top()
# param_4 = obj.getMin()
```