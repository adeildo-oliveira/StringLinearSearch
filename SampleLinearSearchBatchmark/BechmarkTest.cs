using BenchmarkDotNet.Attributes;
using SampleLinearSearch;

namespace SampleLinearSearchBatchmark
{
    [MemoryDiagnoser]
    public class BechmarkTest
    {
        [Benchmark]
        [Arguments("42, starting with a number.")]
        [Arguments("With a number 42 in the middle.")]
        [Arguments("The secret number is 42.")]
        [Arguments("32With a number 52 in the middle.42")]
        [Arguments("42")]
        [Arguments("O(log N) basically means time goes up linearly while the n goes up exponentially. So if it takes 1 second to compute 10 elements, it will take 2 seconds to compute 100 elements, 3 seconds to compute 1000 elements, and so on.")]
        public int ExtractIntUsingLinearSearch(string input)
        {
            var resultado = LinearSearch.Number(input).ToString();
            return int.Parse(resultado);
        }

        [Benchmark]
        [Arguments("42, starting with a number.")]
        [Arguments("With a number 42 in the middle.")]
        [Arguments("The secret number is 42.")]
        [Arguments("32With a number 52 in the middle.42")]
        [Arguments("42")]
        [Arguments("O(log N) basically means time goes up linearly while the n goes up exponentially. So if it takes 1 second to compute 10 elements, it will take 2 seconds to compute 100 elements, 3 seconds to compute 1000 elements, and so on.")]
        public int ExtractIntUsingCompiledRegex(string input)
        {
            var number = RegexSearch.Number(input);
            return int.Parse(number);
        }
    }
}
