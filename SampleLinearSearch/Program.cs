using System;
using System.Diagnostics;

namespace SampleLinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            WithLinearSearch();
            //WithRegexSearch();
        }

        private static void WithLinearSearch()
        {
            Console.WriteLine("Usando Busca Lienar");
            var sw = new Stopwatch();
            sw.Start();
            var gc0 = GC.CollectionCount(0);
            var gc1 = GC.CollectionCount(1);
            var gc2 = GC.CollectionCount(2);

            Console.WriteLine(LinearSearch.Number("42With a number in the middle."));
            Console.WriteLine(LinearSearch.Number("With a number 42 in the middle."));
            Console.WriteLine(LinearSearch.Number("With a number in the middle.42"));
            Console.WriteLine(LinearSearch.Number("With a 52 number in the middle.42"));
            Console.WriteLine(LinearSearch.Number("O(log N) basically means time goes up linearly while the n goes up exponentially. So if it takes 1 second to compute 10 elements, it will take 2 seconds to compute 100 elements, 3 seconds to compute 1000 elements, and so on."));

            sw.Stop();
            Console.WriteLine($"\nTempo: {sw.Elapsed.TotalSeconds}s");
            Console.WriteLine($"  Gen0: {GC.CollectionCount(0) - gc0}");
            Console.WriteLine($"  Gen1: {GC.CollectionCount(1) - gc1}");
            Console.WriteLine($"  Gen2: {GC.CollectionCount(2) - gc2}");
            Console.WriteLine($"Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024}mb");
        }

        private static void WithRegexSearch()
        {
            Console.WriteLine("Usando Regex");
            var sw = new Stopwatch();
            sw.Start();
            var gc0 = GC.CollectionCount(0);
            var gc1 = GC.CollectionCount(1);
            var gc2 = GC.CollectionCount(2);

            Console.WriteLine(RegexSearch.Number("42With a number in the middle."));
            Console.WriteLine(RegexSearch.Number("With a number 42 in the middle."));
            Console.WriteLine(RegexSearch.Number("With a number in the middle.42"));
            Console.WriteLine(RegexSearch.Number("With a 52 number in the middle.42"));
            Console.WriteLine(RegexSearch.Number("O(log N) basically means time goes up linearly while the n goes up exponentially. So if it takes 1 second to compute 10 elements, it will take 2 seconds to compute 100 elements, 3 seconds to compute 1000 elements, and so on."));

            sw.Stop();
            Console.WriteLine($"\nTempo: {sw.Elapsed.TotalSeconds}s");
            Console.WriteLine($"  Gen0: {GC.CollectionCount(0) - gc0}");
            Console.WriteLine($"  Gen1: {GC.CollectionCount(1) - gc1}");
            Console.WriteLine($"  Gen2: {GC.CollectionCount(2) - gc2}");
            Console.WriteLine($"Memory: {Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024}mb");
        }
    }
}
