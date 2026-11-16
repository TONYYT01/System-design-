using System.Runtime.CompilerServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
class Program{
    static void Line()
    {
        Console.WriteLine("============================");
    }
    static void Creating(MySqlConnection connection,string EmpName,int EmpAge,long EmpPH,decimal Salary)
    {
        string MysqlQuary=@"Insert into Employee (EmployeeName,EmployeeAge,EmployeePhoneNO,Salary)
        values(@EmpName,@EmpAge,@EmpPH,@Salary)";
        using MySqlCommand cmd=new MySqlCommand(MysqlQuary,connection);
        cmd.Parameters.AddWithValue("@EmpName",EmpName);
        cmd.Parameters.AddWithValue("@EmpAge",EmpAge);
        cmd.Parameters.AddWithValue("@EmpPH",EmpPH);
        cmd.Parameters.AddWithValue("@Salary",Salary);
        int row =cmd.ExecuteNonQuery();
        if (row> 0)
        {
            Console.WriteLine("Employee added sucessfuly");
        }
    }
    static void Deleteing()
    {
        Console.WriteLine("Deleting Employee...");
    }
    static void Updateing()
    {
        Console.WriteLine("Updataing Employee...");
    }
    static void Viewing()
    {
        Console.WriteLine("Viewing Employee...");
    }
    static void Main(){
    int attampt=0;
    while (attampt<3)
    {
        Console.Write("Enter your User Name : ");
        string UserID=Console.ReadLine()??"";
        Console.Write("Enter Your Password : ");
        string Password=Console.ReadLine()??"";
        String ConnectionString=$"Host=localhost;User={UserID};Password={Password};DataBase=testdb;Port=3306";

        using MySqlConnection connection =new MySqlConnection(ConnectionString);
        try
        {
            connection.Open();
            Console.WriteLine("DB🤞🤞🤞 connected\n");
            int choice;
                do
                {
                    Console.WriteLine("_________CHOOSE_______\n");
                    Console.WriteLine("1 ➕ Add Employee ");
                    Console.WriteLine("2 📖 View Employee");
                    Console.WriteLine("3 👤 Update Employee");
                    Console.WriteLine("4 ➖ Delete Employee");
                    Console.WriteLine("5 🔴 Exit....\n");
                    Console.Write("Enter you Option : ");
                    if (!int.TryParse(Console.ReadLine(),out choice))
                    {
                        Console.WriteLine("Invalid input");
                        choice=0;
                        continue;
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the Employee Name : ");
                            String EmpName=Console.ReadLine()??"";
                            Console.Write("Enter the Age : ");
                            int EmpAge=Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter the Phone number : ");
                            long EmpPH=Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter the Salary : ");
                            decimal Salary=Convert.ToDecimal(Console.ReadLine());
                            Line(); 
                            Creating(connection,EmpName,EmpAge,EmpPH,Salary);
                            break;
                        case 2:
                            Viewing();
                            Line();
                            break;
                        case 3:
                            Updateing();
                            Line();
                            break;
                        case 4:
                            Deleteing();
                            Line();
                            break;
                        case 5:
                            Console.WriteLine("Exiting.....");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;   
                    }
                }
                while(choice!=5);
                break;
        }
        catch(Exception ex)
        {
            Console.WriteLine($"\nDb faild to connect {ex.Message}\n");
            attampt++;
            if (attampt == 3)
            {
                Console.WriteLine("\nYou reached the maximum Attampts");
            }
        }
    }

Console.WriteLine("\nPress Any key to exit");

Console.ReadKey();
}
}