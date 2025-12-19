namespace Palindrome.Tests;

using NUnit.Framework;

[TestFixture]
internal class IsPalindromeExtensionMethodsTests
{
    [Test]
    public void IsPalindrome_ValidEvenPalindrome_ReturnsTrue()
    {
        string input = "abba";

        bool result = input.IsPalindrome();

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindrome_ValidNumberPalindrome_ReturnsTrue()
    {
        string input = "121";

        bool result = input.IsPalindrome();

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindrome_ValidOddPalindrome_ReturnsTrue()
    {
        string input = "aboba";

        bool result = input.IsPalindrome();

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindrome_SingleCharacter_ReturnsFalse()
    {
        string input = "a";

        bool result = input.IsPalindrome();

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPalindrome_InvalidPalindrome_ReturnsFalse()
    {
        string input = "ab";

        bool result = input.IsPalindrome();

        Assert.That(result, Is.False);
    }

    [Test]
    public void IsPalindrome_InvalidNumberPalindrome_ReturnsFalse()
    {
        string input = "12";

        bool result = input.IsPalindrome();

        Assert.That(result, Is.False);
    }

    [TestCase("")]
    [TestCase(" ")]
    [TestCase(null)]
    public void IsPalindrome_InvalidInput_ReturnsFalse(string? input)
    {
        bool result = input.IsPalindrome();

        Assert.That(result, Is.False);
    }
}