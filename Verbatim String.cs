using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp59
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verbatim String
            // \n \t \" \\= \
            //\n = new line
            // \t = tab
            // \\ = print one \


            string speech = "He Said \"some things\" ";
            string path = "C:\\Users\\Parmis\\Final-Projects"; 
            Console.WriteLine(speech); //He Said "some things"
            Console.WriteLine(path);  //C:\Users\Parmis\Final-Projects

            path = @"C:\Users\Parmis\Final-Projects"; 

            Console.WriteLine(path); //C:\Users\Parmis\Final-Projects
            Console.ReadKey();


        }
    }
}
