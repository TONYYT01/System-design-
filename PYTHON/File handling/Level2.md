#### Table of the content 
- [Writeing file](#)

#### Writeing Content to the file
- `write` overwrites the everything remember for sure
- It remove the old data in the file have rewrite the all the thing
```python
import os
if not os.path.exists("text.txt"):
    with open("text.txt","x") as f:
        print("new file created")
with open("text.txt","w") as f:
    f.write("My name is : Naveen")
    f.writelines("\nAge : 21")
```

#### Appending content to the file
- It is add the aditional data to the file without deleting the old content it has 
- Huge file handling and the high industry things we use this append only

```python
import os

if not os.path.exists("text.txt"):
    with open("text.txt","x") as f:
        print("File created")
with open("text.txt","a") as f:
    f.write("\nAddress : Kostalu")
```