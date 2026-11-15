using System;
class Program
{
    static void Main()
    {
        // int Attempt=0;
        // while (Attempt < 3)
        // {
        //     Console.Write("Enter the Your UserName : ");
        //     string UserName=Console.ReadLine()??"";
        //     Console.Write("Enter the Password  :");
        //     string Password=Console.ReadLine()??"";
        //     if (UserName == "Naveen" && Password == "12345")
        //     {
        //         Console.WriteLine("Login Sucess");
        //         Console.WriteLine("Happy to use application");
        //         break;
        //     }
        //     else
        //     {
        //         Console.WriteLine("Invalid username or password");
        //         Attempt++;
        //     }
        // }
        // if (Attempt == 3)
        // {
        //     Console.WriteLine("Maximum Attempts reached");
        // }
        // Console.ReadKey();
        // int choice;
        // do
        // {
        //     Console.WriteLine("____CHOOSE_______");
        //     Console.WriteLine("1 Adding Employe");
        //     Console.WriteLine("2 Modify Employee");
        //     Console.WriteLine("3 Delete Employee");
        //     Console.WriteLine("4 View Empolyee");
        //     Console.WriteLine("5 Exit");
        //     Console.Write("Enter Your Choice : ");
        //     if(!int.TryParse(Console.ReadLine(),out choice))
        //     {
        //         Console.WriteLine("Invalid input");
        //         choice=0;
        //         continue;
        //     }

        //     switch (choice)
        //     {
        //         case 1:
        //             Console.WriteLine("Adding Employee");
        //             break;
        //         case 2:
        //             Console.WriteLine("Modifying Employee");
        //             break;
        //         case 3:
        //             Console.WriteLine("Deleting Employee");
        //             break;
        //         case 4:
        //             Console.WriteLine("View Employee");
        //             break;
        //         case 5:
        //             Console.WriteLine("Exiting Appllication");
        //             break;
        //         default :
        //             Console.WriteLine("Invalid choice");
        //             break;
        //     }
        // }
        // while(choice!=5);
        int Attempt=0;
        while (Attempt < 3)
        {
            Console.Write("Enter Your User Name : ");
            string UserName=Console.ReadLine()??"";
            Console.Write("Enter Your Password : ");
            string Password=Console.ReadLine()??"";
            if (UserName=="Naveen" && Password == "12345")
            {
                Console.WriteLine("Login Sucess");
                Console.WriteLine("happy to Use you application");
                int Choice;
                do
                {
                    Console.WriteLine("_____________CHOOSE_________");
                    Console.WriteLine("1 Employee Add ");
                    Console.WriteLine("2 Employee Edit");
                    Console.WriteLine("3 Employeee Delete");
                    Console.WriteLine("4 Employee Details");
                    Console.WriteLine("5 Exit...");
                    Console.WriteLine("Choose Option:");
                    if(!int.TryParse(Console.ReadLine(),out Choice))
                    {
                        Console.WriteLine("Invalid input");
                        Choice=0;
                        continue;
                    }
                    switch (Choice)
                    {
                        case 1:
                            Console.WriteLine("Adding Employee");
                            break;
                        case 2:
                            Console.WriteLine("Editing Employee");
                            break;
                        case 3:
                            Console.WriteLine("Deleteing Employee");
                            break;
                        case 4:
                            Console.WriteLine("Viewing Employee");
                            break;
                        case 5:
                            Console.WriteLine("Exiting application");
                            break;
                        default :
                            Console.WriteLine("Invaild choice");
                            break;
                    }
                }
                while(Choice!=5);
                break;
            }
            else
            {
                Console.WriteLine("Invalid User Name or Password");
                Attempt++;
            }
        }
        if (Attempt == 3)
        {
            Console.WriteLine("No More Attempts");
        }
        Console.WriteLine("PRESS any key to exit ......");
        Console.ReadKey();
    }
}