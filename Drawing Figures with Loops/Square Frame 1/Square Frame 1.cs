using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            string line = "";

            line = "+";
            for (int i = 1; i <= n - 2; i++)
            {
                line = line + " -";
            }
            line = line + " +";
            Console.WriteLine(line);

            for (int row = 2; row <= n - 1; row++)
            {
                line = "|";
                for (int i = 1; i <= n - 2; i++)
                {
                    line = line + " -";
                }
                line = line + " |";
                Console.WriteLine(line);

            }

            line = "+";
            for (int i = 1; i <= n - 2; i++)
            {
                line = line + " -";
            }
            line = line + " +";
            Console.WriteLine(line);
        }
    }
}
