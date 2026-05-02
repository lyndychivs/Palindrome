namespace Palindrome.PerformanceTests;

public static class Palindrome
{
    public static string Get()
    {
        return new string('a', 1_000) + new string('b', 1_000) + new string('a', 1_000);
    }
}
