namespace Palindrome.Tests;

using NUnit.Framework;

[TestFixture]
internal class IsPalindromeIterativeIterativeExtensionMethodsTests
{
    [Test]
    public void IsPalindromeIterative_ValidEvenPalindrome_ReturnsTrue()
    {
        string input = "abba";

        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindromeIterative_ValidNumberPalindrome_ReturnsTrue()
    {
        string input = "121";

        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindromeIterative_ValidOddPalindrome_ReturnsTrue()
    {
        string input = "aboba";

        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindromeIterative_SingleCharacter_ReturnsFalse()
    {
        string input = "a";

        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPalindromeIterative_InvalidPalindrome_ReturnsFalse()
    {
        string input = "ab";

        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPalindromeIterative_InvalidNumberPalindrome_ReturnsFalse()
    {
        string input = "12";

        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.False);
    }

    [TestCase("")]
    [TestCase(" ")]
    [TestCase(null)]
    public void IsPalindromeIterative_InvalidInput_ReturnsFalse(string? input)
    {
        bool result = input.IsPalindromeIterative();

        Assert.That(result, Is.False);
    }
}