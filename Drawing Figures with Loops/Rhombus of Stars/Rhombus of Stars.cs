using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countspace = n - 1;

            string figure = "";
            for (int row = 1; row <= n; row++)
            {
                string space = new string(' ', countspace);
                if (row == 1)
                    figure = "*";
                else
                    figure = figure + " *";
                Console.WriteLine("{0}{1}", space, figure);
                countspace--;
            }
            countspace = 1;
            for (int row = n - 1; row >= 1; row--)
            {
                figure = figure.Substring(0, figure.Length - 2);

                string space = new string(' ', countspace);
                countspace++;

                Console.WriteLine("{0}{1}", space, figure);
            }
        }
    }
}
