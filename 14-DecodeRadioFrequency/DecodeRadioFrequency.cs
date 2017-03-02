using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DecodeRadioFrequency
{
    class DecodeRadioFrequency
    {
        static void Main()
        {
            var input = Console.ReadLine().Split('.', ' ').Select(Double.Parse).ToArray();

            var countOdd = 0;
            var countEven = 0;

            var sortInput = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sortInput[countEven] = input[i];
                    countEven++;
                }

                else if (i % 2 != 0)
                {
                    sortInput[input.Length - countOdd - 1] = input[i];
                    countOdd++;
                }
            }

            string sumCharacter = "";

            foreach (char item in sortInput)
            {

                if (item != 0)
                {
                    sumCharacter += item;
                }
            }

            Console.WriteLine(sumCharacter);
        }
    }
}
