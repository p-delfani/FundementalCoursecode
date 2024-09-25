using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp58
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fizz Buzz Game
            for(int i = 1; i <= 15; i++) //1-15
            {
                if(i%3==0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else if(i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
    }
}
