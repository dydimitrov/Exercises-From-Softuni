    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace gratestCommonDeviser
    {
        class gratestCommonDeviser
        {
            static void Main(string[] args)
            {
                var firstNumber = int.Parse(Console.ReadLine());
                var secondNumber = int.Parse(Console.ReadLine());

                var greatestNum = Math.Max(firstNumber, secondNumber);
                var lesserNume = Math.Min(firstNumber, secondNumber);
                while (lesserNume!=0)
                {
                    var reminder = greatestNum % lesserNume;
                    greatestNum = lesserNume;
                    lesserNume = reminder;
                }
                Console.WriteLine(greatestNum);
            }
        }
    }
