// using System;
// using System.Collections;
// using System.Diagnostics;
// class Program
// {
//     static void Creating()
//     {
//         Console.WriteLine("I am Just Creating.....");
//     }
//     static void Updating()
//     {
//         Console.WriteLine("I am Updateing....");
//     }
//     static void Deleting()
//     {
//         Console.WriteLine("I am Deleting.....");
//     }
//     static void viewing()
//     {
//         Console.WriteLine("I am Viewing......");
//     }
//     static void Main()
//     {
//         int Attempt=0;
//         while (Attempt < 3)
//         {
//             Console.Write("Enter the User Name : ");
//             string UserName=Console.ReadLine()??"";
//             Console.Write("Enter the Password : ");
//             string Password=Console.ReadLine()??"";
//             if(UserName=="Naveen" && Password == "123")
//             {
//                 Console.WriteLine("Enjoy the application\n");
//                 Console.WriteLine("Login Sucessfully\n\n");
//                 int Choice;
//                 do
//                 {
//                     Console.WriteLine("______CHOOSE______");
//                     Console.WriteLine("1.Add Employee");
//                     Console.WriteLine("2.Update Employee");
//                     Console.WriteLine("3 Delete Employee");
//                     Console.WriteLine("4 View an Employee");
//                     Console.WriteLine("5 Exit...");
//                     Console.Write("\nChoose One : ");

//                     if(!int.TryParse(Console.ReadLine(),out Choice))
//                     {
//                         Console.WriteLine("\nInvalid input");
//                         Choice=0;
//                         continue;
//                     }

//                     switch(Choice){
//                         case 1:
//                             Creating();
//                             break;
//                         case 2:
//                             Updating();
//                             break;
//                         case 3:
//                             Deleting();
//                             break;
//                         case 4:
//                             viewing();
//                             break;
//                         case 5:
//                             Console.WriteLine("\nExiting.....");
//                             break;
//                         default :
//                             Console.WriteLine("\ninvalid Choice");
//                             break;
//                     }
//                 }
//                 while(Choice!=5);
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("Incurrent username or password");
//                 Attempt++;
//             }
//         }
//         if (Attempt == 3)
//         {
//             Console.WriteLine("No more attempts");
//         }
//         Console.WriteLine("\n\nPress Any key to Exit.....");
//         Console.ReadKey();
//     }
// }

// using MySql.Data.MySqlClient;
// string Connectionsstraing="Host=localhost;user=root;password=root123;database=testdb;port=3306";

// using MySqlConnection Connection=new MySqlConnection(Connectionsstraing);

// try
// {
//     Connection.Open();
//     Console.WriteLine("Database connected");
// }
// catch(Exception ex){
//     Console.WriteLine($"Faild to connect db {ex.Message}");
// }

using System.Data;
using MySql.Data.MySqlClient;

class Program
{
    static void Creating(MySqlConnection connection,string Name,int Age)
    {
        string SqlQuary=@"Insert into emp(Name,Age) values(@Name,@Age)";
        using MySqlCommand cmd=new MySqlCommand(SqlQuary,connection);
        cmd.Parameters.AddWithValue("@Name",Name);
        cmd.Parameters.AddWithValue("@Age",Age);
        int row =cmd.ExecuteNonQuery();
        if (row > 0)
        {
            Console.WriteLine("Data entred sucessfuly");
        }
    }
    static void Main()
    {
        Console.Write("Enter the User : ");
        string User=Console.ReadLine()??"";
        Console.Write("Enter the Password ");
        string password=Console.ReadLine()??"";
        string ConnectionString=$"Host=localhost;user={User} ;password={password};database=testdb;port=3306";
        using MySqlConnection connection=new MySqlConnection(ConnectionString);
        try
        {
            connection.Open();
            Console.WriteLine("Db connected");
            string name =Console.ReadLine()??"";
            int Age=Convert.ToInt32(Console.ReadLine());
            Creating(connection,name,Age);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Connection faild {ex.Message}");
        }
    }
}