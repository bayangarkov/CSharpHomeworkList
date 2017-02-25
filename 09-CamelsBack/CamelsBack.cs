using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CamelsBack
{
    class CamelsBack
    {
        static void Main()
        {
            var buildings = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var camelBackSize = int.Parse(Console.ReadLine());

            var rounds = 0;

            if (buildings.Count == camelBackSize)
            {
                Console.WriteLine($"already stable: {string.Join(" ",buildings)}");
                return;
            }

            for (int i = 0; i < buildings.Count; i++)
            {
                if (buildings.Count > camelBackSize)
                {
                    buildings.RemoveAt(0);
                    buildings.RemoveAt(buildings.Count - 1);

                    rounds += 1;
                }
            }

            Console.WriteLine($"{rounds} rounds\nremaining: {string.Join(" ",buildings)}");

        }
    }
}
