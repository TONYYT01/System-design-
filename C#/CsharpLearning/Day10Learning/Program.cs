// class Employee
// {
//     public string Name {get;set;}="";
// }
// class Developer : Employee 
// {
//     public void Getdetails()
//     {
//         Console.WriteLine(Name);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Developer dev=new Developer();
//         dev.Name="Naveen";
//         dev.Getdetails();
//     }
// }


// class Employee
// {
//     public string Name{get;set;}="";

//     public Employee(string name)
//     {
//         Name=name;
//     }
// }
// class Developer : Employee
// {
//     public int ID{get;set;}
//     public Developer(string name,int id) :base (name)
//     {
//         ID=id;
//     }

//     public void Display()
//     {
//         Console.WriteLine(ID);
//         Console.WriteLine(Name);
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Developer dev=new Developer("Naveen",101);
//         dev.Display();
//     }
// }


class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("This is Employee Work ");
    }
}   
class Developer : Employee
{   
    public override void Work()
    {
        Console.WriteLine("This is Develper work");
    }
}

class Program
{
    static void Main()
    {
        Developer dev=new Developer();
        dev.Work();
        Employee Emp=new Employee();
        Emp.Work();
    }
}