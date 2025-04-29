# Palindrome
A simple string extension library for detecting Palindromes.

## Example
```chsarp
string input = "racecar";
bool isPalindrome = input.IsPalindrome(); // true
```

> Note: The library does not treat single characters as palindromes.
```csharp
string input = "a";
bool isPalindrome = input.IsPalindrome(); // false
```