```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn
{
    class Program
    {
        static void Main(string[] args  )
        {
            Console.WriteLine("Hello Buddy !");
            Random random = new Random();
            int number;
            int guess;
            int guesses;
            Boolean play = true;
            string response = "";
            int min = 1;
            int max = 100;

            while (play)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Enter the number : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess" + guess);
                    if (guess > number)
                    {
                        Console.WriteLine(guess + "is to high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + "is to Low");
                    }
                    guesses++;
                }
                Console.WriteLine("Number : " + number);
                Console.WriteLine("You Win!");
                Console.WriteLine("IF you want to play again : (Y/N)");
                response = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    play = true;
                }
                else if(response == "N"){
                    play = false;
                }
            }
            Console.WriteLine("Thanks for playing : ");
            Console.ReadKey();
        }
    }
}

````