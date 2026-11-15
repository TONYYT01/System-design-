using System;

class Program
{
    static void Main()
    {
        //  Today Learning part was
        //  Operators
        // 1 -> Arthmatic Operator
        // 2 -> Relational Operator
        // 3 -> Logical Operator
        // 4 -> Assignment Operator
        // 5 -> Increment /Decrement Operator
        // 6-> Conditional statement

        //  Arthamtic Operator
        // Console.Write("Enter the Any number : ");
        // string a=Console.ReadLine()??"";
        // Console.Write("Enter the Any Number : ");
        // string b=Console.ReadLine()??"";
        // if (int.TryParse(a,out int num1) && (int.TryParse(b,out int num2)))
        // {
        //     Console.WriteLine($"Operator(+) : {num1+num2}");
        //     Console.WriteLine($"Operator(-) : {num1-num2}");
        //     Console.WriteLine($"Operator(*) : {num1*num2}");
        //     Console.WriteLine($"Operator(%) : {num1%num2}");
        //     Console.WriteLine($"Operator(/) : {num1/num2}");
        // }
        // Relational Operator (This will return the Boolean )
        // if (int.TryParse(a,out int num1) && (int.TryParse(b,out int num2)))
        // {
        //     Console.WriteLine($"Operator(==) : {num1==num2}");
        //     Console.WriteLine($"Operator(!=) : {num1!=num2}");
        //     Console.WriteLine($"Operator(<) : {num1<num2}");
        //     Console.WriteLine($"Operator(>) : {num1>num2}");
        //     Console.WriteLine($"Operator(<=) : {num1<=num2}");
        // }
        // else
        // {
        //     Console.WriteLine("Enter the Number only");
        // }
        // Logial Operator (Logical gate based operators)
        // if (int.TryParse(a,out int num1) && (int.TryParse(b,out int num2)))
        // {
        //     Console.WriteLine($"Operator(&&) : {num1<num2 && num1==num2}");
        //     Console.WriteLine($"Operator(||) : {num1!=num2||num1==num2}");
        //     // Console.WriteLine($"Operator(!) : {!num1<num2}");
        // }
        // Assignment Operator
        // if (int.TryParse(a,out int num1) && (int.TryParse(b,out int num2)))
        // {
        //     Console.WriteLine($"This things will printed based on the {num1} only so {num1} is assigned to the num1 variable ");
        //     Console.WriteLine($"Operator(=) : {num1}");
        //     Console.WriteLine($"Operator(+=) : {num1+=num1}");
        //     Console.WriteLine($"Operator(-=) : {num1-=num1}");
        //     Console.WriteLine($"Operator(*=) : {num1*=num1}");
        //     // Console.WriteLine($"Operator(/=) : {num1/=num1}");   System.DivideByZeroException: Attempted to divide by zero.
        //     // Console.WriteLine($"Operator(%=) : {num1%=num1}"); //  System.DivideByZeroException: Attempted to divide by zero.
        // }
        // Increment & Decrement Operator
        // if (int.TryParse(a,out int num1) && (int.TryParse(b,out int num2)))
        // {
        //     Console.WriteLine($"Pre increment(increment first ) : {++num1}");
        //     Console.WriteLine($"Post increment (use first after increment): {num1++}");
        //     Console.WriteLine($"After post increment num1 value is {num1}");
        //     Console.WriteLine($"Pre decrement(decrement first ) : {--num1}");
        //     Console.WriteLine($"Post decrement (use first after decrement): {num1--}");
        //     Console.WriteLine($"After post decrement num1 value is {num1}");
        // }
        // else
        // {
        //     Console.WriteLine("Enter the Number only");
        // }
        
        // Conditional Operators
        // If - Statement

        // Console.Write("Enter the Your Age : ");
        // int Age=Convert.ToInt32(Console.ReadLine());
        // if (Age >= 18)
        // {
        //     Console.WriteLine("You are Major");
        // }
        //  if (Age >= 18)
        // {
        //     Console.WriteLine("You are Major");
        // }
        // else
        // else
        // {
        //     Console.WriteLine("You are Minor");
        // }

        // if-else-if
        // string username="Kola123";
        // string password="Naveen@123";
        // Console.Write("Enter the User name : ");
        // string InputUsername=Console.ReadLine()??"";
        // Console.Write("Enter the Password : ");
        // string InputPassword=Console.ReadLine()??"";
        // if (username==InputUsername && password == InputPassword)
        // {
        //     Console.WriteLine("Login sucess");
        // }
        // else
        // {
        //     Console.WriteLine("Incorrect username or password");
        // }
        // switch statement
        //  Assignment 1
        
        Console.WriteLine("_________CALCULATOR______");
        Console.Write("Enter the Number : ");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Number : ");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the operator : ");
        string Operator=Console.ReadLine()??"";

        if (num2 != 0)
        {
            switch (Operator)
            {
                case "+":
                    Console.WriteLine($"Result {num1+num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result : {num1-num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result : {num1*num2}");
                    break;
                case "/":
                    Console.WriteLine($"Result : {num1/num2}");
                    break;
                case "%":
                    Console.WriteLine($"Reasukt : {num1%num2}");
                    break;
                default:
                    Console.WriteLine("Enter the Valid Operator");
                    break;
            }
        }
        else
        {
            Console.WriteLine($"Result {num1+num2}");
            Console.WriteLine($"Result : {num1-num2}");
            Console.WriteLine($"Result : {num1*num2}");
        }
        Console.WriteLine("Press any key to exit ....");
        Console.ReadKey();
    }
}