using System;

namespace BenchmarkSample
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] bytes = new byte[] { 7, 1, 3, 8, 2 };
            Sorter sorter = new();
            var sorted = sorter.InlineSort(bytes);
            Console.WriteLine(string.Join(",", sorted));
        }
    }
}
