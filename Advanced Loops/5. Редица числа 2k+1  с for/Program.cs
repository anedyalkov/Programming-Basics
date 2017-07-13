using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Редица_числа_2k_1__с_for
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var number = 1;
            for (int i = 0; number <= n; i++)
            {
                Console.WriteLine(number);
                number = 2 * number + 1;
                
            }

        }
    }
}
