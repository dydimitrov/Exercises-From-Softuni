using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfDigits
{
    class sumOfDigits
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sumOfDigits = 0;

            while (number>0)
            {
                sumOfDigits = sumOfDigits + number % 10;
                number = number / 10;
            }
            
            Console.WriteLine(sumOfDigits);
        }
    }
}
