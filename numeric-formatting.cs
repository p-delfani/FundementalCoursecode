using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {
            //numeric formatting 

            double value = 1000D / 12.34D;
            //Console.WriteLine(value);
            Console.WriteLine(string.Format("{0},{1}",value,1000)); //81.0372771474878  //81.0372771474878,1000
            Console.WriteLine(string.Format("{0}", value)); //81.0372771474878 
            Console.WriteLine(string.Format("{0:0}", value)); //81
            Console.WriteLine(string.Format("{0:0.0}", value)); //81.0
            Console.WriteLine(string.Format("{0:0.00}", value)); //81.04


            Console.WriteLine("****************************");

            double money = 10D / 3D; //3.33333333333333
            Console.WriteLine(money);
            Console.WriteLine(string.Format("{0:0}", money)); //3
            Console.WriteLine(string.Format("$10 / $3 = ${0:0.00}",money)); //$10 / $3 = $3.33
            Console.WriteLine(money.ToString("C")); //$3.33
            Console.WriteLine(money.ToString("C0")); //$3
            Console.WriteLine(money.ToString("C1")); //$3.3
            Console.WriteLine(money.ToString("C2")); //$3.33
            Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture)); //$3.33 
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-GB"))); //£3.33
            Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))); //$3.33 



            Console.WriteLine("****************************");





            Console.ReadKey();


        }
    }
}
