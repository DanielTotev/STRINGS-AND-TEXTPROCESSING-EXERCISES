namespace Convert_from_Base_10_to_Base_N
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public class Convertor
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            var baseToConvert = input[0];
            var numberToConvert = input[1];
            var result = CalculateNumber(numberToConvert, baseToConvert);
            Console.WriteLine(result);
        }

        public static string CalculateNumber(BigInteger number, BigInteger baseToConvert)
        {
            var reversedResult = new StringBuilder();
            while (number > 0)
            {
                var digitToAppend = number % baseToConvert;
                reversedResult.Append(digitToAppend);
                number /= baseToConvert;
            }
            var finalResult = Reverse(reversedResult.ToString());

            return finalResult;
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
