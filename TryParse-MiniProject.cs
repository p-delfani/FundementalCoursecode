using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp56
{
    class Program
    {

        static void Main(string[] args)
        {
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number:");
                string numinput = Console.ReadLine();

                if (int.TryParse(numinput, out int num))
                {
                    success = false;
                    Console.WriteLine(num);

                }
                else
                {
                    Console.WriteLine("failed to convert");
                }
                Console.ReadKey();

            }
            
        }
    }
}
