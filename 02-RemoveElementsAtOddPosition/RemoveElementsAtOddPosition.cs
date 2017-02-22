using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RemoveElementsAtOddPosition
{
    class RemoveElementsAtOddPosition
    {
        static void Main()
        {
            var inputWords = Console.ReadLine().Split(' ').ToList();

            var outputWords = new List<string>();

            for (int i = 0; i < inputWords.Count; i++)
            {
                if (i % 2 != 0)
                {
                    outputWords.Add(inputWords[i]);
                }
            }

            foreach (var words in outputWords)
            {
                Console.Write(string.Join("", words));
            }
            Console.WriteLine();
        }
    }
}
