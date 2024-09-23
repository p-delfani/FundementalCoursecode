using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp45
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop
            //for (statement 1; statement 2; statement 3) 
            //{
            //    // code block to be executed
            //}

            //Statement 1 is executed (one time) before the execution of the code block.
            //Statement 2 defines the condition for executing the code block.
            //Statement 3 is executed (every time) after the code block has been executed.

            //for example
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}


            //for (int i = 0; i <= 10; i = i + 2)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }
            Console.ReadKey();

           


        }
    }
}
