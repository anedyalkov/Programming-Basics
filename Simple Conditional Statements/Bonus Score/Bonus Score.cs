using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            double bonuspoints = 0;

            if (number <= 100)
            {
                bonuspoints = 5;
            }
            else if (number > 1000)
            {
                bonuspoints = number * 0.10;
            }
            else
            {
                bonuspoints = number * 0.20;
            }

            if (number % 2 == 0)
            {
                bonuspoints = bonuspoints + 1;
            }
            if (number % 10 == 5)
            {
                bonuspoints = bonuspoints + 2;
            }

            Console.WriteLine(bonuspoints);
            Console.WriteLine(bonuspoints + number);

        }
    }
}
