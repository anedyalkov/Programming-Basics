using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var number1 = int.Parse(Console.ReadLine());


            if (number > number1)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number1);
            }
        }
    }
}
