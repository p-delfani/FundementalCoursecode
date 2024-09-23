using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            //convert string to number
            string textbignumber = "-9000000000";
            long bignumber = Convert.ToInt64(textbignumber);
            Console.WriteLine(bignumber);

            //---------------------//

            string textage = "-23";
            int age = Convert.ToInt32(textage);
            Console.WriteLine(age);

            //---------------------//

            string textnegative = "-55.2";
            double negative = Convert.ToDouble(textnegative);
            Console.WriteLine(negative);

            //---------------------//
            string textprecision = "5.000001";
            float precision = Convert.ToSingle(textprecision);
            Console.WriteLine(precision);

            //---------------------//

            decimal textmoney = 14.99m;
            decimal money = Convert.ToDecimal(textmoney);
            Console.WriteLine(money);

            Console.ReadKey();


        }

    }
}
