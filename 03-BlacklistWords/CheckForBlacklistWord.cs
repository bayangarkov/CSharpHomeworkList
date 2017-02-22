using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_BlacklistWords
{
    class CheckForBlacklistWord
    {
        static void Main()
        {

            string[] blackListWords = Console.ReadLine().Split(' ').ToArray();

            var randomWords = Console.ReadLine();

            var inputWordsWIthoutRemove = new List<string>();

            while (randomWords != "end")
            {
                bool isExist = false;

                for (int i = 0; i < blackListWords.Length; i++)
                {
                    if (randomWords.Contains(blackListWords[i]))
                    {
                        isExist = true;
                    }
                }

                if (isExist != true)
                {
                    inputWordsWIthoutRemove.Add(randomWords);
                }
                randomWords = Console.ReadLine();

            }

            inputWordsWIthoutRemove.Sort();

            foreach (var word in inputWordsWIthoutRemove)
            {
                Console.WriteLine(word);
            }

        }
    }
}
