using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number__0._._._._._100_text
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            string[] numbersInEnglish =  { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] numbersDesetici =  { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] numbersTeens =  { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

            if (number >= 0 && number < 10)
            {
                Console.WriteLine(numbersInEnglish[number]);
            }
            else if (number % 10 == 0 && number != 100)
            {
                Console.WriteLine(numbersDesetici[number / 10 - 1]);
            }
            else if (number > 10 && number < 20)
            {
                Console.WriteLine(numbersTeens[number - 11]);
            }
            else if (number / 10 != 0 && number < 100)
            {
                Console.WriteLine((numbersDesetici[number / 10 - 1]) + " " + (numbersInEnglish[number % 10]));
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                Console.WriteLine("invalid number");
            }

        }
    }
}
