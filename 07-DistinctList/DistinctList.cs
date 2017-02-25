using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_DistinctList
{
    class DistinctList
    {
        static void Main()
        {
            var inputNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var unique = inputNums.Distinct().ToList();

            foreach (var num in unique)
            {
                Console.Write(num + " ");
            }
        }
    }
}
