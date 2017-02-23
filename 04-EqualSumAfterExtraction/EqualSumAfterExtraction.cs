using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EqualSumAfterExtraction
{
    class EqualSumAfterExtraction
    {
        static void Main()
        {
            var listOne = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var listTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var secondWithoutFirst = listTwo.Except(listOne).ToList();

           
            if (listOne.Sum() == secondWithoutFirst.Sum() || listOne.Sum() == listTwo.Sum())
            {
                Console.WriteLine($"Yes. Sum: {listOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(listOne.Sum() - secondWithoutFirst.Sum())}");
            }

        }
    }
}
