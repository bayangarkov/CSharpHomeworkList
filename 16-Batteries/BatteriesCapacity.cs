using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Batteries
{
    class BatteriesCapacity
    {
        static void Main()
        {
            var capacity = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var forOneHour = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var howLong = int.Parse(Console.ReadLine());

            var result = new List<double>();

            for (int i = 0; i < capacity.Count; i++) // 3000 - (350 * 8) = 3000 - (2800);
            {
                result.Add(capacity[i] - (forOneHour[i] * howLong));
            }

            var percentage = 0.0;

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] > 0)
                {
                    percentage = (result[i] / capacity[i]) * 100; // (200 / 3000) * 100 = 6.67;
                    Console.WriteLine($"Battery {i + 1}: {result[i]:f2} mAh ({percentage:f2})%");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {Math.Ceiling(capacity[i] / forOneHour[i])} hours)");
                }
            }
        }
    }
}
