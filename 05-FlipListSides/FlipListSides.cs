using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FlipListSides
{
    class FlipListSides
    {
        static void Main()
        {
            // here we got one list with ints
            // then i remove the first and the last item
            // then reverse the middle 
            // and last put all together but with reversed middle (except first and last item)

            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var flipMiddleSection = new List<int>(firstList);
            
            flipMiddleSection.RemoveAt(0);
            flipMiddleSection.RemoveAt(flipMiddleSection.Count - 1);
            flipMiddleSection.Add(firstList[0]);
            flipMiddleSection.Reverse();
            flipMiddleSection.Add(firstList.Last());

            foreach (var nums in flipMiddleSection)
            {
                Console.Write(nums + " ");
            }
            Console.WriteLine();
        }
    }
}
