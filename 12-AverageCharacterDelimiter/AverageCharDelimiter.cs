using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ').ToArray();

            var sum = 0;

            var counter = 0;
            

            for (int i = 0; i < a.Length; i++)
            {
                foreach (var item in a[i])
                {
                    sum = sum + item;
                    counter++;
                }
            }

            var average = Math.Floor((double)(sum / counter));

            var averageToASCII = (char) average;

            Console.WriteLine(string.Join(averageToASCII.ToString().ToUpper(),a));
            
        }
    }
}
