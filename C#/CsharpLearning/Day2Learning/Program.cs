// using System;

// class Program
// {
// 	static void Main()
// 	{
// 		byte n=1;
// 		Console.WriteLine($"Number {n}");
// 		short Num=234;
// 		Console.WriteLine($"Number {Num}");
// 		int Number=21;
// 		Console.WriteLine($"Number {Number}");
// 		long umber=900000000;
// 		Console.WriteLine($"Number {umber}");
// 	}
// }

// using System;
// class Program
// {
// 	static void Main()
// 	{
// 		float Number =9.04f;
// 		Console.WriteLine(Number);
// 		Double Num=12321.989;
// 		Console.WriteLine(Num);
// 		Decimal dis=87878.98m;
// 		Console.WriteLine(dis);
// 	}
// }

// using System;

// class program
// {
// 	static void Main()
// 	{
// 		Char Alpha='A';
// 		Console.WriteLine(Alpha);
// 	}
// }

// using System;

// class program
// {
// 	static void Main()
// 	{
// 		string Name="Naveen";
// 		Console.WriteLine(Name);
// 	}
// }

// using System;
// class program
// {
// 	static void Main()
// 	{
// 		bool isActive=true;
// 		bool it=false;
// 		Console.WriteLine($"{isActive} , {it}");
// 	}
// }

// using System;

// class program
// {
// 	static void Main()
// 	{
// 		int num=100;
// 		double nums=num;
// 		Console.WriteLine(nums);

// 	}
// }

using System;

class Program
{
	static void Main()
	{
		// Console.WriteLine("Naveen");
		// int num=100;
		// double nums=num;
		// Console.WriteLine(nums);
		// M1 - > 
		// double nums=173.90;
		// int num=(int)nums;
		// Console.WriteLine(num);
		// M2-> Convert class 
		// Double nums=9878.987;
		// int num=Convert.ToInt32(nums);
		// Console.WriteLine(num);
		// M3 - > parse
		// string Number="123";
		// int num=int.Parse(Number);
		// Console.WriteLine(num);
		// M4 - > Tryparse
		// string Number=Console.ReadLine();
		// if (int.TryParse(Number ,out int nums))
		// {
		// 	Console.WriteLine($"{nums}");
		// }
		// else
		// {
		// 	Console.WriteLine("Enter the correct value");
		// }
		// Assignment 1

		Console.Write("Enter the Student Name : ");
		string StudentName=Console.ReadLine();
		Console.Write("Enter the Roll NO : ");
		string RollNo=Console.ReadLine();
		Console.Write("Enter the Student Age : ");
		string Age=Console.ReadLine();
		Console.Write("Enter the Student Percentage : ");
		string Percentage=Console.ReadLine();
		Console.Write("Enter the stdudent Grade : ");
		string Grade=Console.ReadLine();
		Console.Write("Is student is passed : ");
		string Ispassed=Console.ReadLine();

		if ((int.TryParse(Age ,out int StudentAge))&& (float.TryParse(Percentage,out float StudnetPercentage))&&
		(char.TryParse(Grade ,out char studentGrade))&&(bool.TryParse(Ispassed,out bool StudnetPassed)))
		{
			Console.WriteLine("---------######-----------");
			Console.WriteLine($"Studnet Name :{StudentName}");
			Console.WriteLine($"Student Roll no : {RollNo}");
			Console.WriteLine($"Student Age : {StudentAge}");
			Console.WriteLine($"Student Percentage : {StudnetPercentage}");
			Console.WriteLine($"Student Grade : {studentGrade}");
			Console.WriteLine($"Is Student Passed : {StudnetPassed}");
		}
		//  Assignment 2 Type conversion

		// Console.Write("Enter the Any Number : ");
		// string Number =Console.ReadLine();
		// if(int.TryParse(Number,out int intnum))
		// {
		// 	Console.WriteLine($"After converting to the int : {intnum}");
		// }
		// else
		// {
		// 	Console.WriteLine("That is not a number");
		// }
		// double doublenum=Convert.ToDouble(intnum);
		// Console.WriteLine($"int to double {doublenum}");
		// int intn=Convert.ToInt32(doublenum);
		// Console.WriteLine($"Double to int {intn}");

		// Assignment 3 Valid Age input

		// Console.Write("Enter the Your AGE : ");
		// string Age =Console.ReadLine();

		// if (int.TryParse(Age ,out int YourAge))
		// {
		// 	Console.WriteLine($"You age is {YourAge}");
		// }
		// else
		// {
		// 	Console.WriteLine("It is invalid Age enter the age again");
		// }
		Console.WriteLine("Press any key to exit...");

		Console.ReadKey();
	}
}