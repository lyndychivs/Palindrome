.PHONY: help build clean test mutate stryker-install perf

# Variables

help: ## Show this help message
	@echo "Available targets:"
	@grep -E '^[a-zA-Z_-]+:.*?## .*$$' $(MAKEFILE_LIST) | awk 'BEGIN {FS = ":.*?## "}; {printf "  %-20s %s\n", $$1, $$2}'

build: ## Build the Solution in Release mode
	dotnet build --configuration Release

test: ## Run Tests
	dotnet test --project Palindrome.Tests/Palindrome.Tests.csproj --configuration Release --no-build

perf: ## Run Performance Tests
	dotnet run --project Palindrome.PerformanceTests/Palindrome.PerformanceTests.csproj --configuration Release

clean: ## Clean Palindrome build artifacts
	dotnet clean
	rm -rf **/bin **/obj

stryker-install: ## Install Stryker .NET tool
	dotnet tool install dotnet-stryker

mutate: ## Run Stryker Mutation Testing
	dotnet stryker --config-file stryker-config.json
