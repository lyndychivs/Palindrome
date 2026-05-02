namespace Palindrome.PerformanceTests;

using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class IsPalindromeExtensionMethodsTests
{
    private readonly string _palindrome;

    public IsPalindromeExtensionMethodsTests()
    {
        _palindrome = Palindrome.Get();
    }

    [Benchmark]
    public bool IsPalindrome()
    {
        return _palindrome.IsPalindrome();
    }
}
