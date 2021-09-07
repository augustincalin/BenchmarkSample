using BenchmarkDotNet.Attributes;
using BenchmarkSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchRunner
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SortingBenchmarks
    {
        private static readonly byte[] data = new byte[] { 3, 1, 2, 4, 8,2,9 };
        private static readonly Sorter Sorter = new();

        [Benchmark]
        public void SortUsingBubble()
        {
            Sorter.BubbleSort(data);
        }

        [Benchmark]
        public void SortUsingInline()
        {
            Sorter.InlineSort(data);
        }

    }
}
