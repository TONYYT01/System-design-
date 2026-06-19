## Table of Contents

- [IntroDuctiuon](#introductiuon)
- [How java progarm Executes](#how-java-progarm-executes)
- [What is JVM](#what-is-jvm)
- [Responsibilities of JVM](#responsibilities-of-jvm)
- [Jit Compiler](#jit-compiler)
- [JVM Architecture](#jvm-architecture)
- [JRE](#jre)
- [JDK](#jdk)
- [Complete Relationship](#complete-relationship)


### IntroDuctiuon

- java is the one of the high level programming language 
- And it is also a object oriented programming language
- it was developed by the james gosling in 1995 in sun microsystems

- It follow the one of the pricliple  is the WORA
(Write it ones run Anywhere)

### How java progarm Executes

> Suppose see the below code

```java
public class Practice{
    public static  void main(String[] args){
        System.out.println("Hello World!");
    }
}
```
- When i run this one in my teminal 
- Javac File_name.java
- Java File_name
- Output

- Inside what actually happens

```java
Java Source Code
       ↓
Compiler (javac)
       ↓
Bytecode (.class)
       ↓
JVM
       ↓
Machine Code
       ↓
Output
```

### What is JVM
- Java Virtual machine
- It is the heart of the java
- Jvm is the of the virtual machine that runs the bytecode
- produce the Machine code

### Responsibilities of JVM

1. Load Class Files

```java
Hello.class
     ↓
class Loader
```

2. Verifies code
- Security
- Correct code
- illegal code

Before execution

3. Memory management
- Jvm Automatically allocates memory 
> Memory Areas:
```java
JVM Memory
│
├── Method Area
├── Heap
├── Stack
├── PC Register
└── Native Method Stack
```

> Heap Memory

- Objects are store in the Heap memory

> Stack Memory

- Stack memory stores the Local variables and the Method calls

> Garbage Collecction

- java automatically removes the unused Objectes

```java
Student S=new Student();
s= null
```
- Object was unused so it automatically deleted
- No need of performing the any other actions 
5. Executes Bytecode
- Jvm will convert the bytecode into machine code

Uses:

Interpreter

Reads line-by-line.

```java
Bytecode
   ↓
Interpret
   ↓
Execute
```
Slower.

### Jit Compiler

Just intime compiler

- It converts the frequently used code into machine code

### JVM Architecture

```java
                JVM
                 │
    ┌────────────┼────────────┐
    │            │            │
Class Loader  Runtime Area  Execution Engine
    │            │            │
    └────────────┼────────────┘
                 │
         Garbage Collector
```

### JRE
- Java runtime Environment

- JRE provides everything needed to run the java program

> JRE = JVM + Libraries

Contains

```java
JRE
│
├── JVM
├── java.lang
├── java.util
├── java.io
└── Other Libraries
```

### JDK 

- Java Development kit

Used for java Development
> JDK = JRE +Development tools

contains

```java
JDK
│
├── JRE
│   └── JVM
│
├── javac
├── java
├── javadoc
├── jar
├── jdb
└── many tools
```

### Complete Relationship

```java
JDK
│
└── JRE
      │
      └── JVM
```