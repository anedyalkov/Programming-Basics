using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double weekInSofia = (48 - h) * (3.00 / 4);
            double result = ((p * (2.00 / 3)) + h + weekInSofia);
            double result1 = (((p * (2.00 / 3)) + h + weekInSofia)) * 1.15;

            if (year == "normal")
            {
                Console.WriteLine(Math.Truncate(result));
            }
            else if (year == "leap")
            {

                Console.WriteLine(Math.Truncate(result1));
            }
        }
    }
}
