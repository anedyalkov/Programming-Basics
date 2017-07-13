﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x2 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x1 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var horizontal = Math.Abs(x2 - x1);
            var vertical = Math.Abs(y2 - y1);
            var area = (horizontal * vertical);
            var perimeter = (2 * (horizontal + vertical));
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
