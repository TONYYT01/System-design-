## Output

```java
public class Practice {
    public static void main(String[] args){
        System.out.println("Hello World!");
        System.out.println("Hello World!");
        System.out.println("Hello World!");
        System.out.println("Hello World!");
        System.out.println("Hello World!");
        System.out.println("Hello World!");
        System.out.println("Hello World!");
    }
}

```

### Input 

- We will take the userinput by using the Scanner class

```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        System.out.println(a);
        sc.close();
    }
}
```

```java
nextInt()      // Integer
nextDouble()   // Decimal
nextFloat()    // Float
nextLong()     // Long
nextBoolean()  // Boolean
next()         // Single word
nextLine()     // Full sentence
```

- nextLine() -> We can used to move curser next line like 

```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        sc.nextLine();
        String b=sc.nextLine();
        System.out.println(b);
        System.out.println(a);
        sc.close();
    }
}
```

## If else ans switch

```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        if (a>=18){
            System.out.println("YOU are major");
        }
        else{
            System.out.println("YOU are minor");
        }
        sc.close();
    }
}
```
```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        for (int i=1;i<=10;i++){
            System.out.printf("%d X %d = %d%n",a,i,a*i);
        }
        sc.close();
    }
}
```
```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        while (a>0){
            System.out.println(a);
            a--;
        }
        sc.close();
    }
}
```

```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        do{
            System.out.println(a);
            a--;
        }
        while(a>0);
        sc.close();
    }
}
```


```java
import java.util.Scanner;
public class Practice{
    public static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int a=sc.nextInt();
        switch(a){
            case 1:
                System.out.println("Monday");
                break;
            case 2:
                System.out.println("Tuesday");
                break;
            case 3:
                System.out.println("Wednesday");
                break;
            case 4:
                System.out.println("Thuesday");
                break;
            case 5:
                System.out.println("Fryday");
                break;
            case 6:
                System.out.println("Saterday");
                break;
            case 7:
                System.out.println("Sunday");
                break;
            default:
                System.out.println("invalid day");
                break;
        }
        sc.close();
    }
}
```