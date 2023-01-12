using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask
{
    internal class NumberTask
    {
        internal int EnterNumber()
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());

            return n ;
        }

        internal int GetReverseNuber(int number)
        {
            int reverseNumber = 0;
            int n = (int)Math.Log10(number);
            int r;

            while(number != 0)
            {
                r = number % 10;
                reverseNumber += r * (int)Math.Pow(10, n--);
                number /= 10;
            }

            return reverseNumber;
        }



    }
}
