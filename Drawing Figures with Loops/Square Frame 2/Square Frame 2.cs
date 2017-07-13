using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            Console.Write("+");                    //ред първи

            for (int col = 1; col <= n - 2; col++)
            {

                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //Console.WriteLine();




            for (int row = 2; row <= n - 1; row++)
            {
                Console.Write("|");

                for (int col = 1; col <= n - 2; col++)
                {

                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }




            Console.Write("+");                     //ред последен  

            for (int col = 1; col <= n - 2; col++)
            {

                Console.Write(" -");
            }
            Console.Write(" +");

        }
    }
}
