using BenchmarkDotNet.Running;
using System;

namespace BenchRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<SortingBenchmarks>();
        }
    }
}
