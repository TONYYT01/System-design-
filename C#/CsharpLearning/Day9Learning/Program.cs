using System;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

class Employee
{
    public int id{get;set;}
    public string Name {get;set;}="";

    // Public 
    // public long Salary{get;set;}

    // Private
    // private long _Salary;

    //  Get and set method to use 

    private long _Salary;

    private long Salary
    {
        get{
            return _Salary;
            }
        set
        {
            if (value > 0)
            {
                _Salary=value;
            }
            else
            {
                Console.WriteLine("Invalid to set Salary");
            }
        }
    }
    public void SetSalary(long salary)
    {
        Salary=salary;
    }
    public void Viewing()
    {
        Console.WriteLine("ID : "+id);
        Console.WriteLine("NAME : "+Name);
        Console.WriteLine("Salary : "+Salary);
    }
    // When We use the prvate access modifier we will right the method to do any changes through that method 
}
class Program
{
    static void Main()
    {
        Employee Emp1=new Employee();

        //  By using the Public one we will might be get access to all variable and the methods
        // Emp1.id=1;
        // Emp1.Name="Naveen";
        // Emp1.Salary=432132;
        // Emp1.Viewing();
        // Emp1.Salary=98765434567;
        // Emp1.Viewing();

        //  Private
        long salary;
        Emp1.id=1;
        Emp1.Name="Naveen";
        salary=Convert.ToInt64(Console.ReadLine());
        Emp1.SetSalary(salary);
        Emp1.Viewing();
    }
}