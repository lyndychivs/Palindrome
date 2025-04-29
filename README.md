# lyndychivs.Palindrome
[![Mutation testing badge](https://img.shields.io/endpoint?style=for-the-badge&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Flyndychivs%2FPalindrome%2Fmaster)](https://dashboard.stryker-mutator.io/reports/github.com/lyndychivs/Palindrome/master)
[![NuGet Downloads](https://img.shields.io/nuget/dt/lyndychivs.Palindrome?style=for-the-badge&logo=nuget)](https://www.nuget.org/packages/lyndychivs.Palindrome/)

A simple string extension library for detecting Palindromes.

## Examples
```chsarp
string input = "racecar";
bool isPalindrome = input.IsPalindrome(); // true
```

> [!IMPORTANT]
> The library does not treat single characters as palindromes.

```csharp
string input = "a";
bool isPalindrome = input.IsPalindrome(); // false
```
