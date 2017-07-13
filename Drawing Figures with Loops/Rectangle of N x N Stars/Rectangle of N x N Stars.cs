using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int countstars = n;

            for (int row = 1; row <= n; row++)
            {
                string stars = new string('*', countstars);

                Console.WriteLine("{0}", stars);
            }
    }
}
