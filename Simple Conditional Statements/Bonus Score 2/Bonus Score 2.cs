using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            double bonuspoints = 0;

            if (number <= 100)
            {
                bonuspoints += 5;
            }
            else if (number > 1000)
            {
                bonuspoints = number * 0.1;
            }
            else
            {
                bonuspoints = number * 0.2;
            }

            if (number % 2 == 0)
            {
                bonuspoints += 1;
            }
            else if (number % 10 == 5)
            {
                bonuspoints += 2;
            }
            Console.WriteLine("Bonus score: {0}", bonuspoints);
            Console.WriteLine("Total score: {0}", number + bonuspoints);

        }
    }
}
