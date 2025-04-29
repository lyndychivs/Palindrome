namespace Palindrome.Tests
{
    using NUnit.Framework;

    [TestFixture]
    internal class IsPalindromeRecursiveExtensionMethodsTests
    {
        [Test]
        public void IsPalindromeRecursive_ValidEvenPalindrome_ReturnsTrue()
        {
            string input = "abba";

            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindromeRecursive_ValidNumberPalindrome_ReturnsTrue()
        {
            string input = "121";

            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindromeRecursive_InvalidNumberPalindrome_ReturnsFalse()
        {
            string input = "12";

            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindromeRecursive_ValidOddPalindrome_ReturnsTrue()
        {
            string input = "aboba";

            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.True);
        }

        [Test]
        public void IsPalindromeRecursive_SingleCharacter_ReturnsFalse()
        {
            string input = "a";

            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.False);
        }

        [Test]
        public void IsPalindromeRecursive_InvalidPalindrome_ReturnsFalse()
        {
            string input = "ab";

            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.False);
        }

        [TestCase("")]
        [TestCase(" ")]
        [TestCase(null)]
        public void IsPalindromeRecursive_InvalidInput_ReturnsFalse(string? input)
        {
            bool result = input.IsPalindromeRecursive();

            Assert.That(result, Is.False);
        }
    }
}