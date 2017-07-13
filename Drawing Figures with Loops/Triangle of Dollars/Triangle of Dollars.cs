using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //int countstars = n;

            for (int row = 1; row <= n; row++)
            {
                Console.Write("$");
                for (int r = 1; r < row; r++)
                {

                    Console.Write(" $");

                }
                Console.WriteLine();
            }
        }
    }
}
