using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int row = 1; row <= n; row++)     // rows 
            {
                for (int col = 1; col <= n; col++) // columns 
                {
                    if (col == 1)             // first symbol 
                        Console.Write("*");
                    else
                        Console.Write(" *");
                }
                Console.WriteLine();
            }
    }
}
