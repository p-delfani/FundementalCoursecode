using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp65
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = new string[10, 4];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"نام فرد {i * 4 + j + 1}: ");
                    names[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("\nاسامی وارد شده:");

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(names[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }

}
