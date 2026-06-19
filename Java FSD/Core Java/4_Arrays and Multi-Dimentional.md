### Arrays

```java
int m1=24;
int m2=67;
int m3=56;
int m4=89;
int m5=99;
```

- We actually we will assign the marks like this but is this only way to take the marks like this 
- No there is another way also that is arrays 

```java
int [] array={24,67,89,99}
```
- Like this  we can  store it so it store in the continous memory location all those data in a single memory
- Above int's was stored in the different locations
- Array can store the multiple values in a single variable

```java
public class Practice{
    public  static void main(String[] args){
        int[] a={10,20,30,40};
        for (int i=0;i<a.length;i++){
            System.out.print(a[i]+" ");
        }
    }
}
```

- arr.length => return the length of the array
- Index start form 0 same like python
```java
int[] arr={10,89,90}
int arr[]={10,89,90}
// both are accpected
```

#### array input

```java
import java.util.*;
public class Practice{
    public  static void main(String[] args){
        Scanner sc=new Scanner(System.in);
        int[] nums=new int[10];
        int n=nums.length;
        for (int i=0;i<nums.length;i++){
            nums[i]=sc.nextInt();
        }
        for (int i=0;i<n;i++){
            System.out.println(nums[i]);
        }
        sc.close();
    }
}
```

### 2D - array

```java
datatype[][] arrayName;
```

```java
public class Practice{
    public static void main(String[] args){
        int[][] a={{1,2,4},{1,2,3},{1,2,4}};
        for (int i=0;i<a.length;i++){
            for (int j=0;j<a[i].length;j++){
                System.out.print(a[i][j]+" ");
            }
            System.out.println("");
        }
    }
}
```

```java
import java.util.*;
public class Practice{
    public static void main(String[] args){
        int[][] nums=new int[3][3];
        Scanner sc=new Scanner(System.in);
        int n=nums.length;
        for (int i=0;i<n;i++){
            for (int j=0;j<nums[i].length;j++){
                nums[i][j]=sc.nextInt();
            }
        }
        for (int i=0;i<n;i++){
            for (int j=0;j<nums[i].length;j++){
                System.out.print(nums[i][j]+" ");
            }
            System.out.println();
        }
        sc.close();
    }
}
```