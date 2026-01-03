[![Build & Test](https://github.com/lyndychivs/Palindrome/actions/workflows/build-test.yml/badge.svg?branch=main)](https://github.com/lyndychivs/Palindrome/actions/workflows/build-test.yml)
[![Mutation testing badge](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2Flyndychivs%2FPalindrome%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/lyndychivs/Palindrome/main)
[![NuGet Downloads](https://img.shields.io/nuget/dt/lyndychivs.Palindrome?style=flat&logo=nuget)](https://www.nuget.org/packages/lyndychivs.Palindrome/)

# lyndychivs.Palindrome

A simple string extension library for detecting Palindromes.

## Examples
```csharp
string input = "racecar";
bool isPalindrome = input.IsPalindrome(); // true
```

> [!IMPORTANT]
> The library does not treat single characters as palindromes.

```csharp
string input = "a";
bool isPalindrome = input.IsPalindrome(); // false
```

## Tests
All Unit Tests can be found under the [Palindrome.Tests](https://github.com/lyndychivs/Palindrome/tree/main/Palindrome.Tests) namespace.

## Package
Available on:
- [NuGet](https://www.nuget.org/packages/lyndychivs.Palindrome/)
- [GitHub](https://github.com/lyndychivs/Palindrome/pkgs/nuget/lyndychivs.Palindrome)
