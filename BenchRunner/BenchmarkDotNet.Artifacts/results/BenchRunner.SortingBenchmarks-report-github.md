``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6820HK CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|          Method |     Mean |    Error |   StdDev | Rank |  Gen 0 | Allocated |
|---------------- |---------:|---------:|---------:|-----:|-------:|----------:|
| SortUsingInline | 39.35 ns | 0.382 ns | 0.339 ns |    1 | 0.0076 |      32 B |
| SortUsingBubble | 63.01 ns | 1.296 ns | 1.979 ns |    2 | 0.0076 |      32 B |
