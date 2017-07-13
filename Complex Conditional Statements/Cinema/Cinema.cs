using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine().ToLower();
            double RowNumbers = double.Parse(Console.ReadLine());
            double ColumnNumbers = double.Parse(Console.ReadLine());
            var sum = RowNumbers * ColumnNumbers;
            double result = 0.0;

            if (movie == "premiere")
            {
                result = sum * 12.00;
            }
            else if (movie == "normal")
            {
                result = sum * 7.50;
            }
            else if (movie == "discount")
            {
                result = sum * 5.00;
            }

            //if (result > 0) ;
            Console.WriteLine("{0:f2}", result)
        }
    }
}
