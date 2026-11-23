using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
class Employee
{
    public int Id{get;set;}
    public string Name {get;set;}="";
    public int Age{get;set;}
    private long Salary{get;set;}
    public void DataAdd()
    {
        Console.WriteLine("Data added sucessfully");
    }
    public void SetSalary(long salery)
    {
        Salary=salery;
    }
    public void Viewing()
    {
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Age : {Age}");
        Console.WriteLine($"Salary : {Salary}");
    }
}
class Program
{
    static void Main()
    {
        List<Employee> EmployeesData=new List<Employee>();

        int choice;
        do
        {
            Console.WriteLine("______CHOICE_______");
            Console.WriteLine("1 Add new data");
            Console.WriteLine("2 view all data");
            Console.WriteLine("3 search Employee");
            Console.WriteLine("4 TO Exit ....");

            Console.Write("Enter the Choice : ");

            if (!int.TryParse(Console.ReadLine(),out choice))
            {
                Console.WriteLine("Invalid  choice");
                choice=0;
                continue;
            }
            switch (choice)
            {
                case 1:
                    Employee emp=new Employee();
                    Console.Write("Enter the id : ");
                    emp.Id=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Name : ");
                    emp.Name=Console.ReadLine()??"";
                    Console.Write("Enter the Age : ");
                    emp.Age=Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the Salary : ");
                    emp.SetSalary(Convert.ToInt64(Console.ReadLine()));
                    EmployeesData.Add(emp);
                    emp.DataAdd();
                    break;
                case 2:
                    if (EmployeesData.Count == 0)
                    {
                        Console.WriteLine("Data is empty");
                    }
                    foreach(var employee in EmployeesData)
                    {
                        Console.WriteLine("\n ______________________");
                        employee.Viewing();
                    }
                    break;
                case 3:
                    Console.Write("Enter the ID :");
                    int serid=Convert.ToInt32(Console.ReadLine());
                    Employee? serchemp=EmployeesData.Find(e=>e.Id==serid);
                    if (serchemp != null)
                    {
                        Console.WriteLine("Found!");
                        serchemp.Viewing();
                    }
                    else
                    {
                        Console.WriteLine("Employeee not found!");
                    }
                    break;
                case 4:
                    Console.WriteLine("Exiting....");
                    break;
                default:
                    Console.WriteLine("invalid choice ");
                    break;
            }
        }while(choice!=4);
    }
}

 Encapsulation

using System;
class Employee
{
    public string Name {get;set;}="";
    public int Id {get;set;}

    protected long Salary{get;set;}

    public void Viewing()
    {
        Console.WriteLine($"ID : {Id}");
        Console.WriteLine($"Name : {Name}");
        Console.WriteLine($"Salary : {Salary}");
    }
    public void SetSalary(long salary)
    {
        Salary=salary;
    }
}
class Program
{
    static void Main()
    {
        Employee emp=new Employee();
        emp.Id=1;
        emp.Name="Naveen";
        emp.SetSalary(654321);
        emp.Viewing();
    }
}