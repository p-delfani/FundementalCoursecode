using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            //operators

            int age = 23;
            //this three code work same 
            // or age++;
            // or age = age+1;
            // or age+=1;
             age = age-1;
            Console.WriteLine(age);

            age = age*2;
            Console.WriteLine(age);

            age = age % 5;
            Console.WriteLine(age);

            age = age / 3;
          
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
