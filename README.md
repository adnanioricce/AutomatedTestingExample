# Automated Testing Sample

This solution is just a example of various types of automated testing (Unit Tests, Integration Tests, Acceptance Tests, Benchmark Tests) using NUnit and Playwright(for the acceptance tests) alongside a Worker service that runs a Quartz.NET job each two hours.

## Prerequisites

Before getting started, make sure you have the following prerequisites installed on your system:

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Playwright.NET](https://playwright.dev/dotnet/docs/intro)
- [Quartz.NET](https://www.quartz-scheduler.net/)
- NUnit testing framework (typically included with most .NET projects)

## Building the Solution

To build the solution, follow these steps:

1. Clone this repository to your local machine:

   ```bash
   git clone https://github.com/adnanioricce/AutomatedTestingExample.git
   ```

2. Navigate to the root folder of the solution.

3. Open a terminal or command prompt.

4. Run the following command to build the solution:

   ```bash
   dotnet build
   ```

## Running Unit Tests, Integration Tests, and Benchmark Tests

To run the different types of tests, use the following commands:

- **Unit Tests**: NUnit is commonly used for running unit tests in .NET projects.

   ```bash
   dotnet test YourUnitTestsProject
   ```

- **Integration Tests**: You can run integration tests using NUnit as well. Make sure your integration tests project is appropriately configured.

   ```bash
   dotnet test YourIntegrationTestsProject
   ```

- **Benchmark Tests**: If you have benchmark tests in your solution, use the following command to run them:

   ```bash
   dotnet run -c Release --project YourBenchmarkTestsProject
   ```

## Running Acceptance Tests

The Acceptance Tests project uses Playwright.NET for UI automation. Make sure you have Playwright.NET configured for your project.

To run Acceptance Tests:

1. Navigate to the Acceptance Tests project folder.

2. Open a terminal or command prompt.

3. Run the following command:

   ```bash
   dotnet test
   ```

## Running the Worker Service

The Worker service is built using Quartz.NET and is designed to run each project every 2 hours. Follow these steps to run the Worker service:

1. Navigate to the Worker service project folder.

2. Open a terminal or command prompt.

3. Run the following command:

   ```bash
   dotnet run
   ```

The Worker service will schedule and execute the various projects at the specified intervals.
