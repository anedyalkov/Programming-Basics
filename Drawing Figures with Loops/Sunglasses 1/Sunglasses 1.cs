using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());




            string stars = new string('*', 2 * n);
            string spaces = new string(' ', n);

            Console.WriteLine(stars + spaces + stars);



            for (var row = 0; row < n - 2; ++row)

            {

                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");

                if (row == (n - 1) / 2 - 1)
                    Console.Write(new string('|', n));
                else
                    Console.Write(new string(' ', n));



                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");
                Console.WriteLine();

            }


            Console.WriteLine(stars + spaces + stars);

        }
    }
}
