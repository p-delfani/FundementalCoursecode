using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp57
{
    class Program
    {
        static void Main(string[] args)
        {
            //Time table 
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} × {1} = {2}", i, number, i * number);
            }
            Console.ReadKey();

        }
    }
}
