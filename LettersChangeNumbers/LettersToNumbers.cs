using System;
namespace LettersChangeNumbers
{
    public class LettersToNumbers
    {
        public static void Main()
        {
            var specialWords = Console.ReadLine().Split(new[] {' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var sum = 0m;
            for (int i = 0; i < specialWords.Length; i++)
            {
                var currentWord = specialWords[i];
                sum += CalculateWord(currentWord);
            }
            Console.WriteLine($"{sum:f2}");
        }

        public static decimal CalculateWord(string word)
        {
            var firstLetter = word[0];
            var secondLetter = word[word.Length - 1];
            var number = decimal.Parse(word.Substring(1, word.Length - 2));
            if (char.IsUpper(firstLetter))
            {
                var charPosition = (firstLetter - ('A' - 1));
                number /= charPosition;
            }
            else
            {
                number *= (firstLetter - ('a' - 1));
            }

            if (char.IsUpper(secondLetter))
            {
                number -= (secondLetter - ('A' - 1));
            }
            else
            {
                number += (secondLetter - ('a' - 1));
            }
            return number;
        }
    }
}
