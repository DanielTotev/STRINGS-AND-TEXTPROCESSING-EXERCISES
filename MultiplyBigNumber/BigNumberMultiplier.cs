using System;
using System.Text;
namespace MultiplyBigNumber
{
    public class BigNumberMultiplier
    {
        public static void Main()
        {
            var number = Console.ReadLine().TrimStart(new char[] { '0' });
            var digitAsString = Console.ReadLine().TrimStart(new char[] { '0' });
            var digit = 0;
            int.TryParse(digitAsString, out digit);
            var result = Multiply(number, digit);
            Console.WriteLine(result);
        }

        public static StringBuilder Multiply(string number, int digit)
        {
            var reversedResult = new StringBuilder();
            var currentProduct = 0;
            var addition = 0;
            if (digit == 0)
            {
                reversedResult.Append(0);
                return reversedResult ;
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                var currentNumDigit = int.Parse(number[i].ToString());
                currentProduct = (currentNumDigit * digit) + addition;
                if (currentProduct <= 9)
                {
                    reversedResult.Append(currentProduct);
                    addition = 0;
                }
                else
                {
                    reversedResult.Append(currentProduct % 10);
                    addition = currentProduct / 10;
                }
            }
            if (addition != 0)
            {
                reversedResult.Append(addition);
            }
            var result = Reverse(reversedResult);
            return result;
        }
        public static StringBuilder Reverse(StringBuilder text)
        {

            StringBuilder reverse = new StringBuilder();
            for (int i = text.Length - 1; i > -1; i--)
            {
                reverse.Append(text[i]);
            }
            return reverse;
        }
    }
}
