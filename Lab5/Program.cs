using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            int d1, d2;
            int rollCount = 1;
            Random x = new Random();

            Console.WriteLine("Hello!  Welcome to the dice game.\n");

            d1 = AssignDie1();
            d2 = AssignDie2();
            Console.WriteLine();
            while (again)
            {
                Console.WriteLine("Roll "+rollCount);
                Console.WriteLine("======");
                Results(d1,d2,x);
                Console.WriteLine();
                again = RollAgain();
                rollCount++;
            }

        }

        public static int AssignDie1()
        {
            string input;
            int sides;
            Console.WriteLine("Please enter how many sides you would like the first die to have?");
            input = Console.ReadLine();
            if (int.TryParse(input, out sides))
            {
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                sides =AssignDie1();
            }
            return sides;
        }

        public static int AssignDie2()
        {
            string input;
            int sides;
            Console.WriteLine("Please enter how many sides you would like the second die to have?");
            input = Console.ReadLine();
            if (int.TryParse(input, out sides))
            {
            }
            else
            {
                Console.WriteLine("Sorry, that is not a valid input.");
                sides = AssignDie2();
            }
            return sides;
        }

        public static int RollDie(int sides, Random x)
        {
            int roll = x.Next(1, sides);
            return roll;
        }

        public static void Results(int d1, int d2, Random x)
        {
            int rollOne = RollDie(d1,x);
            int rollTwo = RollDie(d2,x);

            if (rollOne==6 && rollTwo==6)
            {
                Console.WriteLine(rollOne);
                Console.WriteLine(rollTwo);
                Console.WriteLine("Boxcars!");
            }
            else if (rollOne==1 && rollTwo==1)
            {
                Console.WriteLine(1);
                Console.WriteLine(1);
                Console.WriteLine("Snake Eyes!");
            }
            else if ((rollOne+rollTwo)==3 || (rollOne+rollTwo)==12)
            {
                Console.WriteLine(rollOne);
                Console.WriteLine(rollTwo);
                Console.WriteLine("Craps!");
            }
            else
            {
                Console.WriteLine(rollOne);
                Console.WriteLine(rollTwo);
            }
        }

        public static bool RollAgain()
        {
            bool again;
            string input;

            Console.WriteLine("Would you like to roll again? (Y/N)");
            input=Console.ReadLine();
            if (input.ToLower()=="y")
            {
                again = true;
            }
            else if (input.ToLower()=="n")
            {
                Console.WriteLine("Goodbye");
                again = false;
            }
            else
            {
                Console.WriteLine("Sorry, I couldn't understand your input.  Let's try again.");
                again = RollAgain();
            }
            return again;
        }


    }
}
