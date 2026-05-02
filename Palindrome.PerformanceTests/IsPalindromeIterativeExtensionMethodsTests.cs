namespace Palindrome.PerformanceTests;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class IsPalindromeIterativeExtensionMethodsTests
{
    private readonly string _palindrome;

    public IsPalindromeIterativeExtensionMethodsTests()
    {
        _palindrome = Palindrome.Get();
    }

    [Benchmark]
    public bool IsPalindromeIterative()
    {
        return _palindrome.IsPalindromeIterative();
    }
}
