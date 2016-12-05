using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printFactorielFromN
{
    class printFactorielFromN
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var factoriel = 1;
            for (int i = 1; i <= number; i++)
            {
                factoriel = factoriel * i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
