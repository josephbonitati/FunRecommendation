using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunRecommendations
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.WriteLine("Greetings Human!");
            Console.WriteLine("What are you in the mood for?");
            Console.WriteLine(" 1) Action");
            Console.WriteLine(" 2) Chilling");
            Console.WriteLine(" 3) Danger");
            Console.WriteLine(" 4) Good Food");


            int result;
            if (int.TryParse(Console.ReadLine(), out result))
            {
                if (result == 1)
                {
                    Console.WriteLine("Action! You should go paintballing!");
                }
                else if (result == 2)
                {
                    Console.WriteLine("Chilling! You should go to the Movies!");
                }
                else if (result == 3)
                {
                    Console.WriteLine("Danger! You should go Cave Exploring!");
                }
                else if (result == 4)
                {
                    Console.WriteLine("Good Food! You should go to Olive Garden!");
                }
                else
                {
                    Console.WriteLine("ERROR ERROR RED ALERT RED ALERT!");
                    goto Start;
                }
            }

            Start2:
            Console.WriteLine("How many people are you going with?");

            
            int numbers;
            if (int.TryParse(Console.ReadLine(), out numbers))
            {
                if (numbers == 0)
                {
                    Console.WriteLine("Sorry to hear that... you should ride a bike!");
                }
                else if (numbers == 1)
                {
                    Console.WriteLine("Wow a frined! You should drive a car!");
                }
                else if (numbers == 2)
                {
                    Console.WriteLine("Wow friends! You should drive a car!");
                }
                else if (numbers == 3)
                {
                    Console.WriteLine("Wow friends! You should drive a car!");
                }
                else if (numbers == 4)
                {
                    Console.WriteLine("Wow friends! You should drive a car!");
                }
                else if (numbers == 5)
                {
                    Console.WriteLine("Theres a lot of you! You should take a limo!");
                }
                else if (numbers == 6)
                {
                    Console.WriteLine("Theres a lot of you! You should take a limo!");
                }
                else if (numbers == 7)
                {
                    Console.WriteLine("Theres a lot of you! You should take a limo!");
                }
                else if (numbers == 8)
                {
                    Console.WriteLine("Theres a lot of you! You should take a limo!");
                }
                else if (numbers == 9)
                {
                    Console.WriteLine("Theres a lot of you! You should take a limo!");
                }
                else if (numbers == 10)
                {
                    Console.WriteLine("Theres a lot of you! You should take a limo!");
                }
                else if (numbers >= 11)
                {
                    Console.WriteLine("Aren't you popular! You should take a private jet!");
                }
                else
                {
                    Console.WriteLine("ERROR ERROR RED ALERT RED ALERT!");
                    goto Start2;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Have Fun! Come again!");
            Console.ReadKey();
            goto Start;

        }
    }
}
