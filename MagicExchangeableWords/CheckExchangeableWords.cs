using System;
using System.Collections.Generic;

namespace MagicExchangeableWords
{
    public class CheckExchangeableWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();
            var firstWord = words[0];
            var secondWord = words[1];
            int len = Math.Min(firstWord.Length, secondWord.Length);
            var map = new Dictionary<char, char>();
            for (int i = 0; i < len; i++)
            {
                if (!map.ContainsKey(firstWord[i]))
                {
                    if (map.ContainsValue(secondWord[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    map[firstWord[i]] = secondWord[i];
                }
                else
                {
                    if (map[firstWord[i]] != secondWord[i])
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }

            }

            if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("true");
            }

            if (firstWord.Length != secondWord.Length)
            {
                var longerWord = firstWord.Length > secondWord.Length ? firstWord : secondWord;
                var subStr = longerWord.Substring(len);
                var isContained = true;
                foreach (var ch in subStr)
                {
                    if (!(map.ContainsKey(ch) || map.ContainsValue(ch)))
                    {
                        isContained = false;
                        break;
                    }
                }

                if (isContained)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
          
        }
    }
}
