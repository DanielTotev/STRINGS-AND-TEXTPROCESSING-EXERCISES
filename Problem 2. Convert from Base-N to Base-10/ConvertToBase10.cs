using System;
using System.Numerics;

namespace Problem_2.Convert_from_Base_N_to_Base_10
{
    public class ConvertToBase10
    {
        public static void Main()
        {
            var inputParams = Console.ReadLine().Split();
            var numberAsString = inputParams[1];
            var currentBase = int.Parse(inputParams[0]);
            var numberInBase10 = Calculate(numberAsString, currentBase);
            Console.WriteLine(numberInBase10);
            
        }

        public static BigInteger Calculate(string numberAsString, int currentBase)
        {
            var NumberAsSrtingReversed = Reverse(numberAsString);
            BigInteger result = 0;
            for (int i = 0; i < NumberAsSrtingReversed.Length; i++)
            {
                var digit = int.Parse(NumberAsSrtingReversed[i].ToString());
                result  += digit * BigInteger.Pow(currentBase, i);
            }
            
            return result;
        }

        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
    }
}
