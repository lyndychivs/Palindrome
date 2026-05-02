namespace Palindrome.PerformanceTests;

using BenchmarkDotNet.Running;

internal static class Program
{
    private static void Main()
    {
        _ = BenchmarkRunner.Run<IsPalindromeExtensionMethodsTests>();
        _ = BenchmarkRunner.Run<IsPalindromeIterativeExtensionMethodsTests>();
        _ = BenchmarkRunner.Run<IsPalindromeRecursiveExtensionMethodsTests>();
    }
}
