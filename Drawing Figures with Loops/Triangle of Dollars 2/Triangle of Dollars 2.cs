using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_of_Dollars_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string line = "$";
            string space = " ";
            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= row; i++)
                {
                    Console.Write(line + space);
                }
                Console.WriteLine();

            }
        }
    }
}
