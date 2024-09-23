using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            string numberainput = Console.ReadLine();
            int numbera = Convert.ToInt32(numberainput);

            Console.WriteLine("Enter the second number");
            string numberbinput = Console.ReadLine();
            int numberb = Convert.ToInt32(numberbinput);

            int answer = numbera * numberb;


            Console.WriteLine("value of" + numbera + "x" + numberb + ":");
            string answerinput = Console.ReadLine();
            int actualanswer = Convert.ToInt32(answerinput);

            if(answer == actualanswer)
            {
                Console.WriteLine("well done");
            }
            else
            {
                Console.WriteLine("close but it was wrong");

            }

            Console.ReadKey();


        }
    }
}
