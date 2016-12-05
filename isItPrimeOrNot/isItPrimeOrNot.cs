using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isItPrimeOrNot
{
class isItPrimeOrNot
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var isPrime = true;
        if (number < 2)
        {
            Console.WriteLine("Not Prime");

        }
        else
        {
            for (int devisor = 2; devisor < number; devisor++)
            {
                if (number % devisor == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }

    }
}
}
