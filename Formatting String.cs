using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp60
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formatting String

            //string name = "parmis";
            //int age = 19;
            //Console.WriteLine("Name: "+name);
            //Console.WriteLine("age: "+age);
            //Console.WriteLine();
            //Console.WriteLine("Name: " + name +"\nage: "+age);
            //Console.ReadKey();

            Console.WriteLine("Enter your name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Name is {0} \nYour age is {1}", name,age);
            Console.ReadKey();
        }
    }
}
