class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Insert_Head(head,data):
    new_node=Node(data)
    new_node.next=head
    head=new_node
    return head
def Solve(value):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Insert_Head(head,value)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve(5)