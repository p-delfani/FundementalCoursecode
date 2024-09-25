using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp63
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empty String

            Console.WriteLine("Enter your name PLease ...");
            string name = Convert.ToString(Console.ReadLine());
            

            if(name != "")
            {
                Console.WriteLine("Hello and welcome dear {0}",name);
            }
            else
            {
                Console.WriteLine("Your name is Empty");

            }
            Console.ReadKey();


        }
    }
}
