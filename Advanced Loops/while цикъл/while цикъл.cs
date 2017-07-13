using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_цикъл
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());


            int countstars = 1;
            if (n % 2 == 0) countstars = 2;
            int countspaceout = (n - countstars) / 2;

            string space = new string('-', countspaceout);
            string stars = new string('*', countstars);
            if (n > 2)
                Console.WriteLine("{0}{1}{0}", space, stars);

            //----------------------------------------------- first row

            countspaceout--;
            int countspacein = 0;

            for (int row = 1; row <= (n - 1) / 2; row++)
            {
                countspacein = n - 2 - 2 * countspaceout;
                string outspace = new string('-', countspaceout);
                string inspace = new string('-', countspacein);
                Console.WriteLine("{0}*{1}*{0}", outspace, inspace);

                countspaceout -= 1;
                countspacein += 2;
            }


            //---------------------------------- upper half
            countspaceout = 1;

            countspacein = n - 2 - 2 * countspaceout;

            while ((countspacein = n - 2 - 2 * countspaceout) > 0)
            {
                string outspace = new string('-', countspaceout);
                string inspace = new string('-', countspacein);
                Console.WriteLine("{0}*{1}*{0}", outspace, inspace);

                countspaceout++;
                countspacein-=2;	
            }
            //----------------------------- lower half


            if (n % 2 == 0) countstars = 2;
            countspaceout = (n - countstars) / 2;


            space = new string('-', countspaceout);
            stars = new string('*', countstars);
            //if( n > 2) 
            Console.WriteLine("{0}{1}{0}", space, stars);// last row

        }
    }
}
