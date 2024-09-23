using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise odd/even checker without(if)

            int num1 = 10;
            int num2 = 2;
            int reminder = num1 % num2;
            Console.WriteLine(reminder); //0
            // now beacuse the result is 0 so 10 is a odd number

            int num3 = 11;
            int num4 = 2;
            int reminder2 = num3 % num4;
            Console.WriteLine(reminder2); //1
            // now beacuse the result is 1 so 10 is a oven number

            Console.ReadKey();
        }
    }
}
