class Node:
    def __init__(self,data):
        self.data=data
        self.next=None
def Delete_Any(head,pos):
    if head is None:
        return None
    if pos==1:
        return head.next
    temp=head
    for i in range(pos-2):
        if temp.next is None:
            return head
        temp=temp.next
    temp.next=temp.next.next
    return head
def Solve(pos):
    first=Node(10)
    second=Node(20)
    third=Node(30)
    first.next=second
    second.next=third
    head=first
    head=Delete_Any(head,pos)
    temp=head
    while temp:
        print(temp.data)
        temp=temp.next
    print("None")
Solve(30)