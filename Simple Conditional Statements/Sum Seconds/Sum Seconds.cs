using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            var sum = sec1 + sec2 + sec3;
            var min = sum / 60;
            var sec = sum % 60;


            Console.WriteLine("{0}:{1:00}", min, sec);
        }
    }
}
