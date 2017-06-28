using System;
using System.Text;

namespace SumBigNumbers
{
    public class BigNumberSumator
    {
        public static void Main()
        {
            var firstNumberAsString = Console.ReadLine().TrimStart(new char[] { '0' });
            var secondNumberAsString = Console.ReadLine().TrimStart(new char[] { '0' });
            var result = SumNumbers(firstNumberAsString, secondNumberAsString);
            Console.WriteLine(result);
        }

        public static StringBuilder SumNumbers(string firstNumberAsString, string secondNumberAsString)
        {
            var biggerNumber = new StringBuilder();
            var smallerNumber = new StringBuilder();

            if (secondNumberAsString.Length >= firstNumberAsString.Length)
            {
                biggerNumber.Append(secondNumberAsString);
                smallerNumber.Append(new string('0', secondNumberAsString.Length - firstNumberAsString.Length)).Append(firstNumberAsString);
            }
            else
            {
                biggerNumber.Append(firstNumberAsString);
                smallerNumber.Append(new string('0', firstNumberAsString.Length - secondNumberAsString.Length)).Append(secondNumberAsString);
            }

            var residue = 0;
            var result = new StringBuilder();

            for (int i = biggerNumber.Length - 1; i >= 0; i--)
            {
                var biggerNumDigit = int.Parse(biggerNumber[i].ToString());
                var smallerNumDigit = int.Parse(smallerNumber[i].ToString());
                var sum = biggerNumDigit + smallerNumDigit + residue;

                if (sum <= 9)
                {
                    result.Append(sum);
                    residue = 0;
                }
                else
                {
                    result.Append(sum % 10);
                    residue = sum / 10;
                }
            }

            if (residue != 0)
            {
                result.Append(residue);
            }

            result = Reverse(result);

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
