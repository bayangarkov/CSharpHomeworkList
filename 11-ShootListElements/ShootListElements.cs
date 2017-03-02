﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ShootListElements
{
    class ShootListElements
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var numbers = new List<int>();

            var lastElement = 0;

            while (!input.Equals("stop"))
            {
                if (!input.Equals("bang"))
                {
                    numbers.Insert(0, Convert.ToInt32(input));
                }
                
                if (input.Equals("bang"))
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastElement}");
                        return;
                    }

                    var averageSum = numbers.Average();
                    var deleteElement = 0;

                    foreach (var num in numbers)
                    {
                        if (num <= averageSum)
                        {
                            deleteElement = num;
                            break;
                        }
                    }

                    numbers.Remove(deleteElement);

                    Console.WriteLine($"shot {deleteElement}");

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] = numbers[i] - 1;
                    }

                    lastElement = deleteElement;
                }
                

                input = Console.ReadLine();
            }

            if (numbers.Count > 0)
            {
                Console.WriteLine($"survivors: {(string.Join(" ", numbers))}");
            }
            else
            {
                Console.WriteLine($"you shot them all. last one was {lastElement}");
            }
        }
    }
}
