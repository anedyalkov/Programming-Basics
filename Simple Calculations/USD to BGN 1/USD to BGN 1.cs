using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USD =");
            double USD = double.Parse(Console.ReadLine());
            double BGN = Math.Round(USD * 1.79549, 2);

            Console.WriteLine("BGN = " + BGN);
        }
    }
}
