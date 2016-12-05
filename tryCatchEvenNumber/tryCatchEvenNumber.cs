using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchEvenNumber
{
    class tryCatchEvenNumber
    {
        static void Main(string[] args)
        {
            var number = 0;
            while (true)
            {
                try
                {
                    Console.Write("Enter even number:");
                    number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine("Even number entered : {0}", number);
                        break;
                    }                  

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number");
                    
                }
                
                
            }
        }
    }
}
