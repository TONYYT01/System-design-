using MySql.Data.MySqlClient;
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
            Line();
        }
    }
    static void Deleteing(MySqlConnection connection,int Employeeid)
    {
        string DelQuary=@"Delete from Employee Where EmployeeID=@Employeeid";
        using MySqlCommand cmd=new MySqlCommand(DelQuary,connection);
        cmd.Parameters.AddWithValue("@Employeeid",Employeeid);
        int delrow=cmd.ExecuteNonQuery();
        if (delrow > 0)
        {
            Console.WriteLine("Deleted Sucessfully");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
    static void UpdateName(MySqlConnection connection,int id,string Name)
    {
        string upnaQuary=@"Update Employee set EmployeeName=@Name where EmployeeID=@id";
        using MySqlCommand cmd=new MySqlCommand(upnaQuary,connection);
        cmd.Parameters.AddWithValue("@Name",Name);
        cmd.Parameters.AddWithValue("@id",id);
        int row=cmd.ExecuteNonQuery();
        if (row > 0)
        {
            Console.WriteLine("Updated sucessfully");
        }
        else
        {
            Console.WriteLine("Employee not Found");
        }
    }
    static void UpdateAge(MySqlConnection connection,int Emid,int EmAge)
    {
        string AgeQuary=@"update Employee set EmployeeAge =@EmAge where EmployeeID=@Emid";
        using MySqlCommand cmd=new MySqlCommand(AgeQuary,connection);
        cmd.Parameters.AddWithValue("@Emid",Emid);
        cmd.Parameters.AddWithValue("@EmAge",EmAge);
        int Agerow=cmd.ExecuteNonQuery();
        if (Agerow > 0)
        {
            Console.WriteLine("Updated sucessfully");
        }
        else
        {
            Console.WriteLine("Employee not Found");
        }
    }
    static void UpdatePhone(MySqlConnection connection,int EmpId,long EmpPhone)
    {
        string PhoneQuary=@"Update Employee set EmployeePhoneNO=@EmpPhone where EmployeeID=@EmpId";
        using MySqlCommand cmd=new MySqlCommand(PhoneQuary,connection);
        cmd.Parameters.AddWithValue("@EmpPhone",EmpPhone);
        cmd.Parameters.AddWithValue("@EmpId",EmpId);
        int PhoneRow=cmd.ExecuteNonQuery();
        if (PhoneRow > 0)
        {
            Console.WriteLine("Updated sucessfully ");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
    static void Viewing(MySqlConnection connection,int Id)
    {
        string Quary="Select * from Employee where EmployeeID=@Id";
        using MySqlCommand cmd=new MySqlCommand(Quary,connection);
        cmd.Parameters.AddWithValue("@Id",Id);
        using MySqlDataReader reader=cmd.ExecuteReader();
        if (reader.Read())
        {
            Line();
            Console.WriteLine("           User data");
            Line();
            Console.WriteLine($"Employee ID : {reader["EmployeeID"]}");
            Console.WriteLine($"EmpName : {reader["EmployeeName"]}");
            Console.WriteLine($"Employee Age : {reader["EmployeeAge"]}");
            Console.WriteLine($"Employee Phone number : {reader["EmployeephoneNo"]}");
            Console.WriteLine($"Employee Salary : {reader["Salary"]}");
        }
        else
        {
            Console.WriteLine("Employee not found");
        }
    }
    static void EmployeesData(MySqlConnection connection)
    {
        string Quary="Select * from Employee";
        using MySqlCommand cmd=new MySqlCommand(Quary,connection);
        using MySqlDataReader reader=cmd.ExecuteReader();
        Line();
        Console.WriteLine("       Employeesss      ");
        Line();
        int check=0;
        while (reader.Read())
        {
            Console.WriteLine($"Employeee ID : {reader["EmployeeID"]}");
            Console.WriteLine($"Employeee Name : {reader["EmployeeName"]}");
            Console.WriteLine($"Employeee Age : {reader["EmployeeAge"]}");
            Console.WriteLine($"Employee Phone Number : {reader["EmployeePhoneNO"]}");
            Console.WriteLine($"Employee Salary : {reader["Salary"]}");
            Line();
            check++;
        }
        if (check == 0)
        {
            Console.WriteLine("Data is Empty");
        }

    }

    static void Main(){
    int attampt=0;
    while (attampt<3)
    {
        // Console.Write("Enter your User Name : ");
        // string UserID=Console.ReadLine()??"";
        // Console.Write("Enter Your Password : ");
        // string Password=Console.ReadLine()??"";
        String ConnectionString=$"Host=localhost;User=root;Password=root123;DataBase=testdb;Port=3306";
        // String ConnectionString=$"Host=localhost;User={UserID};Password={Password};DataBase=testdb;Port=3306";

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
                    Console.WriteLine("5 🤵‍♂️Employees Data");
                    Console.WriteLine("6 🔴 Exit....\n");
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
                            Console.Write("Enter the Employee ID : ");
                            int id=Convert.ToInt32(Console.ReadLine());
                            Viewing(connection,id);
                            Line();
                            break;
                        case 3:
                            int upchoice;
                            do
                            {
                                Line();
                                Console.WriteLine("1 update Name");
                                Console.WriteLine("2 Update Age");
                                Console.WriteLine("3 update phone no");
                                Console.WriteLine("4 Go back");
                                Line();
                                Console.Write("Enter the option :");
                                if(!int.TryParse(Console.ReadLine(),out upchoice))
                                {
                                    Console.WriteLine("Invalid choice");
                                    upchoice=0;
                                    continue;
                                }
                                switch (upchoice)
                                {
                                    case 1:
                                        Console.Write("Enter the Employee Id : ");
                                        int upid=Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter the Employee : ");
                                        string UpName=Console.ReadLine()??"";
                                        Line();
                                        UpdateName(connection,upid,UpName);
                                        break;
                                    case 2:
                                        Console.Write("Enter the Employee ID : ");
                                        int Emid=Convert.ToInt32(Console.ReadLine());
                                        Console.Write("Enter the Employee Age : ");
                                        int EmAge=Convert.ToInt32(Console.ReadLine());
                                        Line();
                                        UpdateAge(connection,Emid,EmAge);
                                        break;
                                    case 3:
                                        Console.Write("Enter the Employee ID : ");
                                        int EmpId=Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Enter the Employee Phone number");
                                        long EmpPhone=Convert.ToInt64(Console.ReadLine());
                                        Line();
                                        UpdatePhone(connection,EmpId,EmpPhone);
                                        break;
                                    case 4:
                                        Line();
                                        Console.WriteLine("Ok Going Back....");
                                        Line();
                                        break;
                                    default :
                                        Console.WriteLine("Invalid choice");
                                        break;
                                }
                            }
                            while(upchoice!=4);
                            break;
                        case 4:
                            Console.Write("Enter the Employee ID : ");
                            int Employeeid=Convert.ToInt32(Console.ReadLine());
                            Line();
                            Deleteing(connection,Employeeid);
                            break;
                        case 5:
                            EmployeesData(connection);
                            break;
                        case 6:
                            Console.WriteLine("Exiting.....");
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;   
                    }
                }
                while(choice!=6);
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