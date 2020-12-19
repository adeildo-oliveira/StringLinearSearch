using BenchmarkDotNet.Running;

namespace SampleLinearSearchBatchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<BechmarkTest>();
        }
    }
}
