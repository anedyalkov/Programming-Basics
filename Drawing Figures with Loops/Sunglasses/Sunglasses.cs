using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string upperpart = "";
            string space = "";



            upperpart = new string('*', 2 * n);
            space = new string(' ', 5 * n - 2 * n - 2 * n);

            Console.WriteLine("{0}{1}{0}", upperpart, space);



            string middlepart = new string('/', 2 * n - 2);
            string frames = new string('|', n);

            for (int row = 1; row <= n - 2; row++)
            {
                if (row == ((1 + (n - 2)) / 2))
                {
                    Console.WriteLine("*{0}*{1}*{0}*", middlepart, frames);
                }
                else
                {
                    Console.WriteLine("*{0}*{1}*{0}*", middlepart, space);
                }
            }



            string downpart = new string('*', 2 * n);
            Console.WriteLine("{0}{1}{0}", downpart, space);

        }
    }
}
