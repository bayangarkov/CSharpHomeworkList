using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_IntegerInsertion
{
    class IntegerInsertion
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var numbersToInsert = Console.ReadLine();
            
            while (numbersToInsert != "end")
            {
                var getTheFirstNum = Convert.ToInt32(numbersToInsert);

                while (getTheFirstNum >= 10)
                {
                    getTheFirstNum /= 10;
                }

                numbers.Insert(getTheFirstNum, Convert.ToInt32(numbersToInsert));

                numbersToInsert = Console.ReadLine();

            }

            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
        }
    }
}
