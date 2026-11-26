using System;

abstract class Employee
{
    public string Name {get;set;}="";
    public abstract void Work();
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} : I am writinng the code");
    }
}
class Tester : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} : is test the code ");
    }
}
class Manager: Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} : is Setting up the teams");
    }
}
class Program
{
    static void Main()
{
    Employee[] employees={new Developer{Name="Naveen"},new Tester{Name="Raghu"},new Manager{Name="Chaitu"}};

    foreach (Employee emp in employees)
    {
        emp.Work();
    }
}

}

using System;

abstract class Employee
{
    public string Name {get;set;}="";
    public abstract void Work();
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine($"{Name} : is developer");
    }
}
class Program{
    static void Main()
    {
        Employee Emp1=new Developer();
        Emp1.Name="Naveen";

        Emp1.Work();

    }
}

using System;

interface Iinterface1
{
    void Add(int a,int b);
}

interface Iinterface2
{
    void Sub(int a,int b);
}

class Implementation :Iinterface1,Iinterface2
{
    // public void Add(int a,int b)
    void Iinterface1.Add(int a, int b)
    {
        Console.WriteLine(a+b);
    }
    // public void Sub(int a,int b)
    void Iinterface2.Sub(int a, int b)
    {
        Console.WriteLine(a-b);
    }
}
class Program{
    static void Main()
    {
        Implementation imp=new Implementation();
        // imp.Add(2,4);
        // imp.Sub(5,9);

        Iinterface1 i=imp;
        Iinterface2 j=imp;
        i.Add(3,4);
        j.Sub(8,2);
    }
}

In this smart phine implementation

using System;

interface ICamera
{
    void start();
}

interface Iphonecall
{
    void start();
}

interface IMusicplayer
{
    void start();
}

class SmartPhone:ICamera,Iphonecall,IMusicplayer
{
    void ICamera.start()
    {
        Console.WriteLine("Camera is started");
    }
    void Iphonecall.start()
    {
        Console.WriteLine("calling started");
    }
    void IMusicplayer.start()
    {
        Console.WriteLine("Music player started");
    }
}

class Program
{
    static void Main()
    {
        SmartPhone phone=new SmartPhone();
        ICamera camera=phone;
        Iphonecall iphonecall=phone;
        IMusicplayer musicplayer=phone;
        camera.start();
        iphonecall.start();
        musicplayer.start();
    }
}

Build a Document Management System.

using System;
using System.Security;
interface IPrintable
{
    void print();
}
interface Isave
{
    void save();
}
interface IDelete
{
    void Delete();
}

class PdfDocument : IPrintable, Isave, IDelete
{
    void IPrintable.print()
    {
        Console.WriteLine("Pdf is printing");
    }
    void Isave.save()
    {
        Console.WriteLine("Pdf is saving");
    }
    void IDelete.Delete()
    {
        Console.WriteLine("Pdf is Deleting");
    }
}
class WordDocument : IPrintable,Isave,IDelete
{
    void IPrintable.print()
    {
        Console.WriteLine("Word is printing");
    }
    void IDelete.Delete()
    {
        Console.WriteLine("Word is Deleting");
    }
    void Isave.save()
    {
        Console.WriteLine("word is Saveing");
    }
}

class Program
{
    static void Main()
    {
        PdfDocument pdfDocument=new PdfDocument();
        IPrintable printable=pdfDocument;
        IDelete delete=pdfDocument;
        Isave isave=pdfDocument;

        WordDocument wordDocument=new WordDocument();
        IPrintable printable1=wordDocument;
        IDelete delete1=wordDocument;
        Isave isave1=wordDocument;
        printable.print();
        delete.Delete();
        isave.save();
        Console.WriteLine();
        printable1.print();
        delete1.Delete();
        isave1.save();

        PdfDocument pdfDocument=new PdfDocument();
        WordDocument wordDocument=new WordDocument();

        IPrintable[] printables={pdfDocument,wordDocument};
        Isave[] isaves={pdfDocument,wordDocument};
        IDelete[] delete={pdfDocument,wordDocument};

        foreach (IPrintable printable in printables)
        {
            printable.print();
        }
        foreach (Isave isave in isaves)
        {
            isave.save();
        }
        foreach(IDelete delete1 in delete)
        {
            delete1.Delete();
        }
    }
}

