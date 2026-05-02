namespace Palindrome.PerformanceTests;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class IsPalindromeRecursiveExtensionMethodsTests
{
    private readonly string _palindrome;

    public IsPalindromeRecursiveExtensionMethodsTests()
    {
        _palindrome = Palindrome.Get();
    }

    [Benchmark]
    public bool IsPalindromeRecursive()
    {
        return _palindrome.IsPalindromeRecursive();
    }
}
