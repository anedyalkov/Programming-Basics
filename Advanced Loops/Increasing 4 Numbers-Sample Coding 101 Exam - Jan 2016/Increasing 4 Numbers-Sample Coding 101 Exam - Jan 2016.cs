using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing_4_Numbers_Sample_Coding_101_Exam___Jan_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var count = 0;

            for (int n1 = a; n1 <= b; n1++)
            {
                for (int n2 = n1+1; n2 <= b; n2++)
                {
                    for (int n3 = n2+1; n3 <= b; n3++)
                    {
                        for (int n4 = n3+1; n4 <= b; n4++)
                        {
                           
                            
                                Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
                                count++;
                           
                        }
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
