using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_UnunionList
{
    class UnunionList
    {
        static void Main()
        {
            var primal = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var loopList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                foreach (var num in loopList)
                {
                    if (primal.Contains(num))
                    {
                        primal.Remove(num);
                    }
                    else
                    {
                        primal.Add(num);
                    }
                }
            }

            primal.Sort();
            Console.Write(string.Join(" ",primal));
        }
    }
}
