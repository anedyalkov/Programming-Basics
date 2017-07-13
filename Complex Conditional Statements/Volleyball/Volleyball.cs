using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int weekendsInhome = int.Parse(Console.ReadLine());
            double weekendsInSofia = (48 - weekendsInhome) * (3.00 / 4);
            double result = ((holidays * (2.00 / 3)) + weekendsInhome + weekendsInSofia);
            double result1 = (((holidays * (2.00 / 3)) + weekendsInhome + weekendsInSofia)) * 1.15;

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
