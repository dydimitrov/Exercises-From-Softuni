using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciSeaquense
{
    class fibonacciSeaquense
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var f0 = 1;
            var f1 = 1;
            for (int i = 1; i < n; i++)
            {
                var fnext = f0 + f1;
                f0 = f1;
                f1 = fnext;
            }
            Console.WriteLine(f1);
        }
    }
}
