using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _15_ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() })
                        .OrderByDescending(x => x.Count);
            

            foreach (var x in q)
            {
                var result = x.Count * 100.0 / list.Count;
                Console.WriteLine(x.Value + " -> " + x.Count + " times" + " ({0:F2}%)",result);
            }
            
        }
    }
}
