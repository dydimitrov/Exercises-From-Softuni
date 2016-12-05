using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberPyramid
{
class numberPyramid
{
    static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine());
        var counter = 1;

        for (int currentRow = 1; currentRow <= number; currentRow++)
        {
            for (int currentCol = 1; currentCol <= currentRow; currentCol++)
            {
                    if (counter == number+1)
                    {
                        break;
                    }
                Console.Write("{0} ",counter);
                counter++;
            }
                Console.WriteLine();
                if (counter == number + 1)
                {
                    break;
                }

            }
        }
}
}
