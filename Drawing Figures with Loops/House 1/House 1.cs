using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int countStars = 1;
            int countSpaces = 1;
            int row = 1;

            if (row == 1 && n % 2 == 0)
            {
                countStars = 2;
                countSpaces = (n - countStars) / 2;
            }

            else if (row == 1 && n % 2 != 0)
            {
                countStars = 1;
                countSpaces = (n - countStars) / 2;
            }




            for (row = 1; row <= (1 + n) / 2; row++)
            {

                string spaces = new string('-', countSpaces);
                string stars = new string('*', countStars);


                Console.WriteLine("{0}{1}{0}", spaces, stars);
                countStars = countStars + 2;
                countSpaces--;
            }







            for (row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                for (int i = 1; i <= n - 2; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("|");
            }
        }
    }
}
