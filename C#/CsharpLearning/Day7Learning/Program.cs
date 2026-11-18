using System;   
class Employee
{
    public string Name {get;set;}
    public int Age {get;set;}
    private long Salary {get;set;}=988888;
    public void Display()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(Salary);
    }
}
class Program
{
    static void Main()
    {
        Employee emp1=new Employee();
        emp1.Name="Naveen";
        emp1.Age=21;
        // emp1.Salary=8000000;
        emp1.Display();
        Program.Main();
    }
}

Above on is upto 8 concept 

 Concept 9 this key word

using System;

class Employee
{
    public int EmployeeID {get;set;}
    public Employee(int EmployeeID)
    {
        this.EmployeeID=EmployeeID;
    }
    public void Display()
    {
        Console.WriteLine(EmployeeID);
    }
}

class Program
{
    static void Main()
    {
        Employee emp=new Employee(1);
        Console.WriteLine(emp.EmployeeID);
        emp.Display();
    }
}

 Concept 10 static vs instance

using System;

class Employee
{
    public string EmployeeName {get;set;}
    public static string CompanyName="ABC Tech";
}
class Program
{
    static void Main()
    {
        Employee emp=new Employee();
        emp.EmployeeName="Naveen";
        Console.WriteLine(emp.EmployeeName);
        Console.WriteLine(Employee.CompanyName);
    }
}