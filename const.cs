using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            //const
            const int vat = 20; // with this const now you can't change the value of this variable

            const double percentvat = vat / 100D;

            int balance = 1000;
            Console.WriteLine((balance * (vat / 100D)));
            Console.WriteLine(balance * percentvat);
            Console.WriteLine(vat);

            Console.ReadKey();

        }
    }
}
