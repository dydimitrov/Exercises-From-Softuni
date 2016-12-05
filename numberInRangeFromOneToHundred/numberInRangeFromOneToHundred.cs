using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberInRangeFromOneToHundred
{
    class numberInRangeFromOneToHundred
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            var number = int.Parse(Console.ReadLine());
            while (number<1 || number>100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);

        }
    }
}
