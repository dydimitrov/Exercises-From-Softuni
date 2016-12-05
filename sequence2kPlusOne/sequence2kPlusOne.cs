using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequence2kPlusOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (int i = 0; num <= n; i++)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
