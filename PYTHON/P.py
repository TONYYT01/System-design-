with open("Text.txt","r") as f:
    line=f.readlines()
    print(line[0].strip())