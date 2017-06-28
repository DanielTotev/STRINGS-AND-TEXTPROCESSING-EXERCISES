using System;
using System.Text;
namespace UnicodeCharacters
{
    public class Unicode
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = GetUniCode(text);
            Console.WriteLine(result);
        }

        public static StringBuilder GetUniCode(string text)
        {
            var result = new StringBuilder();
            foreach (var character in text)
            {
                var unicode = GetEscapeSequence(character);
                result.Append(unicode);
            }

            return result;
        }
        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("x4");
        }
    }
}
