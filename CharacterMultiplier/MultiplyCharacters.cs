using System;
using System.Numerics;
namespace CharacterMultiplier
{
    public class MultiplyCharacters
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
            var result = CalculateStrings(input[0], input[1]);
            Console.WriteLine(result);
        }

        public static BigInteger CalculateStrings(string firstString, string secondString)
        {
            BigInteger result = 0;

            var minLength = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < minLength; i++)
            {
                int firstValue = firstString[i];
                int secondValue = secondString[i];
                result += (firstValue * secondValue);
            }
            if (firstString.Length > secondString.Length)
            {
                var initalString = firstString.Substring(minLength);
                for (int i = 0; i < initalString.Length; i++)
                {
                    result += initalString[i];
                }
            }
            else if (secondString.Length > firstString.Length)
            {
                var initalString = secondString.Substring(minLength);
                for (int i = 0; i < initalString.Length; i++)
                {
                    result += initalString[i];
                }
            }
            return result;
        }
    }
}
