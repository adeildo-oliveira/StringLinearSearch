using System.Text;
using System.Text.RegularExpressions;

namespace SampleLinearSearch
{
    public class LinearSearch
    {
        private static readonly StringBuilder sb = new StringBuilder();

        public static StringBuilder Number(string input)
        {
            sb.Clear();

            for (var i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    sb.Append(input[i]);
            }

            return sb;
        }
    }

    public class RegexSearch
    {
        static Regex numberExtractor = new Regex(@"\d+", RegexOptions.Compiled);

        public static string Number(string input) => numberExtractor.Match(input).Value;
    }
}
