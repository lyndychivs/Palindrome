namespace Palindrome
{
    /// <summary>
    /// Extension methods for checking if a string is a Palindrome.
    /// </summary>
    public static class PalindromeExtensionMethods
    {
        /// <summary>
        /// Returns true if <see cref="string"/> is a Palindrome.
        /// </summary>
        /// <param name="input">The input <see cref="string"/>.</param>
        /// <returns>Returns <see cref="bool"/> true if the input is a Palindrome.</returns>
        public static bool IsPalindrome(this string input)
        {
            return IsPalindromeIterative(input);
        }

        /// <summary>
        /// Returns true if <see cref="string"/> is a Palindrome.
        /// (using an Iterative method).
        /// </summary>
        /// <param name="input">The input <see cref="string"/>.</param>
        /// <returns>Returns <see cref="bool"/> true if the input is a Palindrome.</returns>
        public static bool IsPalindromeIterative(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if (input.Length == 1)
            {
                return false;
            }

            int leftIndex = 0;
            int rightIndex = input.Length - 1;

            while (leftIndex <= rightIndex)
            {
                if (char.ToLower(input[leftIndex]) != char.ToLower(input[rightIndex]))
                {
                    return false;
                }

                leftIndex++;
                rightIndex--;
            }

            return true;
        }

        /// <summary>
        /// Returns true if <see cref="string"/> is a Palindrome.
        /// (using an Recursive method).
        /// </summary>
        /// <param name="input">The input <see cref="string"/>.</param>
        /// <returns>Returns <see cref="bool"/> true if the input is a Palindrome.</returns>
        public static bool IsPalindromeRecursive(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            if (input.Length == 1)
            {
                return false;
            }

            return IsPalindrome(input, 0, input.Length - 1);
        }

        private static bool IsPalindrome(string input, int leftIndex, int rightIndex)
        {
            if (leftIndex > rightIndex)
            {
                return true;
            }

            if (char.ToLower(input[leftIndex]) != char.ToLower(input[rightIndex]))
            {
                return false;
            }

            return IsPalindrome(input, leftIndex + 1, rightIndex - 1);
        }
    }
}