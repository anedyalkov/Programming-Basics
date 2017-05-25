using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            for (var i = 1; i <= n; i++)
            {


                var num = int.Parse(Console.ReadLine());
                sum = sum + num;
            }
            //Console.WriteLine(sum);

            var sum1 = 0;
            for (var i = 1; i <= n; i++)
            {


                var num = int.Parse(Console.ReadLine());
                sum1 = sum1 + num;
            }
            //Console.WriteLine(sum1);
            if (sum == sum1)
            {
                Console.WriteLine(" Yes, sum = " + Math.Abs(sum));
            }
            if (sum != sum1)
            {
                Console.WriteLine(" No, diff = " + Math.Abs(sum - sum1));
            }

        }
    }
}
