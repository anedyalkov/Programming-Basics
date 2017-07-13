using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int countmiddle = n - 2;

            Console.Write("+");
            for (int row = 1; row <= countmiddle; row++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");


            for (int r = 1; r <= countmiddle; r++)
            {
                Console.Write("|");
                for (int row = 1; row <= countmiddle; row++)
                {
                    Console.Write(" -");
                }
                Console.Write(" |");
                Console.WriteLine();
            }

            Console.Write("+");
            for (int row = 1; row <= countmiddle; row++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
