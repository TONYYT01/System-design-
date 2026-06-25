### String

- Not only in java string in every programming language it was an sequence of characture and we can store the text amount of data
- What actually the use of the string

> For example

```java
public class Practice{
    public static void main(String[] ags){
        String a="Naveen";
        System.out.println(a);
    }
}
```

- If incase we don't have the concept of the string

```java
public class Practice{
    public static void main(String[] ags){
        char c1='N';
        char c2='A';
        char c3='V';
        char c4='E';
        char c5='E';
        char c6='N';
        System.out.print((c1));
        System.out.print((c2));
        System.out.print((c3));
        System.out.print((c4));
        System.out.print((c5));
        System.out.print((c6));
    }
}
```
- This is the reason we need to use the string in our progarm


- This two ways we can create the string

```java
String a="Naveen";

String a=new String("Naveen")
```

### String concatenation

- we can concatenate the string to string and the with variables als0

```java
public class Practice{
    public  static void main(String[] args){
        String Name="Naveen";
        int a1=23;
        System.out.println(Name+" "+a1);
    }
}
```

> String Length

```java
public class Practice{
    public  static void main(String[] args){
        String Name="Naveen";
        int a1=23;
        System.out.println(Name.length());
    }
}
```

> Convert to upper case


```java
public class Practice{
    public  static void main(String[] args){
        String Name="Naveen";
        int a1=23;
        System.out.println(Name.toUpperCase());
    }
}
```

> Convert to Lowercase

```java
public class Practice{
    public  static void main(String[] args){
        String Name="Naveen";
        int a1=23;
        System.out.println(Name.toLowerCase());
    }
}
```

> charAt() return the characture at the index


```java
public class Practice{
    public  static void main(String[] args){
        String Name="Naveen";
        int a1=23;
        System.out.println(Name.charAt(0));
    }
}
```

> indexOf() find the position of the characture

```java
public class Practice{
    public  static void main(String[] args){
        String Name="Naveen";
        int a1=23;
        System.out.println(Name.indexOf("a"));
    }
}
```

> equals() compare the string content

```java
public class Practice{
    public  static void main(String[] args){
        String Name= "Naveen";
        String FirstName="Kola";
        System.out.println(Name.equals(FirstName));
    }
} // false
```

```java
public class Practice{
    public  static void main(String[] args){
        String Name=new String("Naveen");
        String FirstName=new String("Naveen");
        System.out.println(Name.equals(FirstName));
    }
} // True
```

```java
public class Practice{
    public  static void main(String[] args){
        String Name=new String("Naveen");
        String FirstName=new String("Naveen");
        System.out.println(Name==FirstName);
    }
} // false 
```

`==` it will check the memory address

> contains()

```java
public class Practice{
    public  static void main(String[] args){
        String data="I love java";
        System.out.println(data.contains("love"));
    }
} // true
```

> startsWith()

```java
public class Practice{
    public  static void main(String[] args){
        String data="I love java";
        System.out.println(data.startsWith("I"));
    }
} //true
```

> endsWith()

```java
public class Practice{
    public  static void main(String[] args){
        String data="I love java";
        System.out.println(data.endsWith("va"));
    }
}
```

> substring()

```java
public class Practice{
    public  static void main(String[] args){
        String data="I love java";
        System.out.println(data.substring(0,8));
    }
}
```

> replace()

```java
public class Practice{
    public  static void main(String[] args){
        String data="I love java";
        System.out.println(data.replace("java","Python"));
}
}
```

> trim 
- Remove the spaces from the start and the end

```java
public class Practice{
    public  static void main(String[] args){
        String data="             I love java";
        System.out.println(data.trim());
}
}
```

> split()
- Break string into parts

```java
public class Practice{
    public  static void main(String[] args){
        String data="I love java";
        String[] words=data.split(",");
        for (int i=0;i<words.length;i++){
            System.out.println(words[i]);
        }
}
}
```

### Taking String Input
Single Word
```java
Scanner sc = new Scanner(System.in);

String name = sc.next();

System.out.println(name);
```
Input:

Tony

Output:

Tony
Full Sentence
```java
Scanner sc = new Scanner(System.in);

String sentence = sc.nextLine();

System.out.println(sentence);

```
Input:

I Love Java

Output:

I Love Java


### String vs StringBuilder

String:
```java

String s = "Java";
```
Immutable
Slower for many modifications

StringBuilder:
```java
StringBuilder sb = new StringBuilder("Java");
```
Mutable
Faster

Example:
```java
StringBuilder sb = new StringBuilder("Java");

sb.append(" Programming");

System.out.println(sb);
```
Output:

Java Programming

