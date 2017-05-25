﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string full = new string('*', n);
            string empty = new string(' ', n - 2);

            Console.WriteLine(full);
            for (var i = 2; i <= n - 1; ++i)
                Console.WriteLine("*" + empty + "*");
            Console.WriteLine(full);
        }
    }
}
