### Table of the contents
- [What is file](#files)
- [Modes in files](#modes-we-have)
## Files
- So files are used to store the data so it could be any of the data actully 
- Raw and the binary and normal like txt,csv,json 

### Open read close

- Example:
- Basic example of reading the file
```python
f=open("data.txt","r")
content=f.read()
print(content)
f.close()
```
### Modes we have
- `"r"`-> Read
- `"a"`->append(add content)
- `"w"`-> Write(overwrites file)
- `"x"`-> Creates the new file

#### USE `with` keyword
- By using the with keyword we don't want to think about the close of an file
- It is an industry  standard always use the `with` 
```python
with open("data.txt","r") as f:
    content=f.read()
    print(content)
```
#### 🧪 Practice (Do this now)
- Create test.txt
- Write your name inside
- Read it using Python

```python
with open("text.txt","r") as f:
    content=f.read()
    print(content)
```
- [Level2](Level2.md)