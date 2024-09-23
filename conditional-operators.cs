using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp50
{
    class Program
    {
        static void Main(string[] args)
        {
            //conditional operators
            // if your age is 10  result is valid 
            // if your age is -10 result is invaild
            int age = 10;

            string result = age >= 0 ? "valid" : "invalid";
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
