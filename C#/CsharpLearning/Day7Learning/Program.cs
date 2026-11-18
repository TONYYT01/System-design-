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



using System;

class Employee
{
    public string Name{get;set;}
    public int Age{get;set;}
    private long Salary{get;set;}
    public void Viewing()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Age);
        Console.WriteLine(Salary);
    }
}
class Program
{
    public static void Main()
    {   
        Employee emp=new Employee();
        Employee emp2=new Employee();
        emp2.Name="Raghu";
        emp2.Age=22;
        emp.Viewing();
        emp2.Viewing(); 
    }
}

using System;

class Employee
{
    public string _Name;
    public string Name
    {
        get{return _Name;}
        set
        {
            if (value!="")
                _Name=value;
        }
    }
}
class Program
{
    static void Main()
    {
        Employee emp=new Employee();
        emp.Name="naveen";
        Console.WriteLine(emp.Name);
    }
}

using System;

class Employee
{
    public string Name{get;set;}
    private string Salary{get;set;}
    public static void Viewing(Employee emp)
    {
        Console.WriteLine(emp.Name);
        Console.WriteLine(emp.Salary);
    }
    public void Setsalary(string salary)
    {
        Salary=salary;
    }
}
class Program
{
    static void Main()
    {
        Employee emp=new Employee();
        emp.Name="Naveen";
        emp.Setsalary("9888899");
        Employee.Viewing(emp);

        Employee emp1=new Employee();
        emp1.Name="raghu";
        emp1.Setsalary("986789878");
        Employee.Viewing(emp1);
        // Console.WriteLine()
    }
}

using System;

class Employee
{
    public int Id{get;set;}
    public string Name{get;set;}

    public  Employee(string name,int id)
    {
        Console.WriteLine(this.Id=id);
        Console.WriteLine(this.Name=name);
    }
}
class Program
{
    public static void Main()
    {
        Employee em=new Employee("Naveen",1);
        // em.Viewing();
    }

}

using System;

class Employee
{
    public int id{get;set;}
    public  string Name{get;set;}

    public static int salary=231;
    public void viewing()
    {
        Console.WriteLine(id);
        Console.WriteLine(Name);
        Console.WriteLine(salary);
    }
}
class Program
{
    static void Main()
    {
        Employee Emp=new Employee();
        Emp.Name="Naveen";
        Emp.id=123;
        Console.Write(Employee.salary);
        Emp.viewing();
    }
}