using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            var result = 0.0;
            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                result = a * a;
            }
            else if (figure == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double c = double.Parse(Console.ReadLine());
                result = b * c;
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());

                result = Math.PI * r * r; ;
            }
            else if (figure == "triangle")
            {
                double d = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());

                result = (d * h) / 2;
            }



            Console.WriteLine("{0:f3}", result);
        }
    }
}
