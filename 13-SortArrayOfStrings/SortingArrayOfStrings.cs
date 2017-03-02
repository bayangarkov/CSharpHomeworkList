using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_SortArrayOfStrings
{
    class SortingArrayOfStrings
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (input[j - 1].CompareTo(input[j]) == 1)
                    {
                        var temp = input[j - 1];
                        input[j - 1] = input[j];
                        input[j] = temp;
                    }
                    j--;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
