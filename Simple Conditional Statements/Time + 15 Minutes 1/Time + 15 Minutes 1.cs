﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int result = hours * 60 + minutes + 15;
            int newhours = result / 60;
            if (newhours >= 24)
            {
                newhours -= 24;
            }
            int newminutes = result % 60;

            Console.WriteLine("{0}:{1}", newhours, newminutes.ToString().PadLeft(2, '0'));
        }
    }
}
