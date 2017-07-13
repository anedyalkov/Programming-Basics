using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class House
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int countspace = (n - 1) / 2;
            int countstars = 1;



            if (n % 2 == 0)
                countstars = 2;


            for (int row = 1; row <= (n + 1) / 2; row++)
            {
                string space = new string('-', countspace);
                string stars = new string('*', countstars);
                Console.WriteLine("{0}{1}{0}", space, stars);
                countstars += 2;
                countspace--;
            }



            for (int row = 1; row <= n - ((n + 1) / 2); row++)
            {
                countstars = n - 2;
                string stars = new string('*', countstars);
                Console.WriteLine("|{0}|", stars);
            }






        }
    }
}
