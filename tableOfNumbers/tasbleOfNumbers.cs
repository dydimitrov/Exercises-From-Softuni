using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tableOfNumbers
{
    class tasbleOfNumbers
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int currentRow = 0; currentRow < number; currentRow++)
            {
                for (int currentCol = 0; currentCol < number; currentCol++)
                {
                    var numForPrint = currentRow + currentCol + 1;
                    if (numForPrint>number)
                    {
                        numForPrint = 2 * number - numForPrint;
                    }
                    Console.Write(numForPrint + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
