# Palindrome Performance Tests

This project contains performance benchmarks for the palindrome checking methods using [BenchmarkDotNet](https://benchmarkdotnet.org/).

## Running the Tests

```bash
make perf
```

> **Note:** Always run performance tests in **Release** configuration for accurate results.

## Results

Test Environment:
- **OS**: Windows 11 (10.0.26200.8246/25H2)
- **CPU**: Snapdragon X Plus - X1P42100 - Qualcomm Oryon CPU 3.24GHz
- **.NET**: .NET 10.0.7
- **BenchmarkDotNet**: v0.15.8

### Performance Comparison

| Method | Mean | Error | StdDev | Allocated |
|--------|--------|--------|--------|-----------|
| **IsPalindromeIterative** | **3.133 μs** | 0.0021 μs | 0.0018 μs | - |
| IsPalindrome | 3.134 μs | 0.0018 μs | 0.0017 μs | - |
| IsPalindromeRecursive | 12.10 μs | 0.005 μs | 0.004 μs | - |

## Test Classes

- **IsPalindromeExtensionMethodsTests** - Benchmarks the main `IsPalindrome()` extension method
- **IsPalindromeIterativeExtensionMethodsTests** - Benchmarks the `IsPalindromeIterative()` method
- **IsPalindromeRecursiveExtensionMethodsTests** - Benchmarks the `IsPalindromeRecursive()` method

## Detailed Reports

Full benchmark reports (CSV, HTML, Markdown) are generated in:
```
BenchmarkDotNet.Artifacts\results\
```
