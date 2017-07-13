using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {

            var sum = double.Parse(Console.ReadLine());
            string currency1 = (Console.ReadLine());
            string currency2 = (Console.ReadLine());
            double CCY = 1.0;
            //double CC2 = 1.0;

            if (currency1 == "EUR")
            {
                CCY = 1.95583;
            }

            else if (currency1 == "USD")
            {
                CCY = 1.79549;
            }
            else if (currency1 == "GBP")
            {
                CCY = 2.53405;
            }
            else if (currency1 == "BGN")
            {
                CCY = 1;
            }
            //Console.WriteLine("{0:F2}", sum * CC1);

            if (currency2 == "EUR")
            {
                CCY = CCY / 1.95583;
            }

            else if (currency2 == "USD")
            {
                CCY = CCY / 1.79549;
            }
            else if (currency2 == "GBP")
            {
                CCY = CCY / 2.53405;
            }
            else if (currency2 == "BGN")
            {
                CCY = CCY / 1;
            }

            Console.WriteLine("{0:F2}", sum * CCY);
        }
    }
}
