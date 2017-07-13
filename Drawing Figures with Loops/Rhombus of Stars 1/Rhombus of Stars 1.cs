using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //string star = " *";
            //string space = "-";

            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= n - row; i++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");





                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }


            for (int row = n - 1; row >= 1; row--)
            {
                for (int i = 1; i <= n - row; i++)
                {
                    Console.Write(" ");

                }
                Console.Write("*");





                for (int i = 1; i <= row - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();




            }
        }
    }
}
