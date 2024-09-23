using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement
            //Less than: a < b
            //Less than or equal to: a <= b
            //Greater than: a > b
            //Greater than or equal to: a >= b
            //Equal to a == b
            //Not Equal to: a != b


            //if (condition) 
            //{
                // block of code to be executed if the condition is True
            //}

            //if (20 > 18) 
            // {
            //    Console.WriteLine("20 is greater than 18");
            //}

            //int x = 20;
            //int y = 18;
            //if (x > y)
            //{
            //    Console.WriteLine("x is greater than y");
            //}

            //if (condition)
            //{
            //  block of code to be executed if the condition is True
            //}
            //else
            //{
            //block of code to be executed if the condition is False
            //}

            //int time = 20;
            //if (time < 18)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}
            //// Outputs "Good evening."
            ///
            //if (condition1)
            //{
            //    // block of code to be executed if condition1 is True
            //}
            //else if (condition2)
            //{
            //    // block of code to be executed if the condition1 is false and condition2 is True
            //}
            //else
            //{
            //    // block of code to be executed if the condition1 is false and condition2 is False
            //}

            //int time = 22;
            //if (time < 10)
            //{
            //    Console.WriteLine("Good morning.");
            //}
            //else if (time < 20)
            //{
            //    Console.WriteLine("Good day.");
            //}
            //else
            //{
            //    Console.WriteLine("Good evening.");
            //}
            // Outputs "Good evening."




            //now try:
            uint number = Convert.ToUInt16(Console.ReadLine());


            if (number < 10)
            {
                Console.WriteLine("your number is tak ragami");

            }

            else
            {
                Console.WriteLine("your number is do ragami");

            }

            Console.ReadKey();
        }
    }
}
