using System;

namespace MarlehShake
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                var leftIndex = input.IndexOf(key);
                var rightIndex = input.LastIndexOf(key);

                var leftIndexExists = leftIndex != -1;
                var rightIndexExists = rightIndex != -1;
                var keyIsNotEmpty = key != string.Empty;

                var indexesAreEqual = leftIndex == rightIndex;

                if (leftIndexExists && rightIndexExists && !indexesAreEqual && keyIsNotEmpty)
                {
                    input = input.Remove(rightIndex, key.Length);
                    input = input.Remove(leftIndex, key.Length);
                  
                    Console.WriteLine("Shaked it.");
                    key = key.Remove(key.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
