using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    class Program
    {
        static void Main(string[] args)
        {
            //Try Parse
            Console.WriteLine("Enter a numebr");
            string numinput = Console.ReadLine(); //10h
            int num = 0;
            int.TryParse(numinput, out num);

            Console.WriteLine(num); //0

            Console.ReadKey();

        }
    }
}
