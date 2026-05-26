# CalculatorServiceDemo

A simple console application built with **.NET 8.0** and **C#** that demonstrates a basic Calculator Service containing arithmetic operations and helper math utilities.

---

## 📂 Project Structure

```text
CalculatorServiceDemo/
│
├── CalculatorServiceDemo.sln       # Visual Studio Solution file
│
└── src/
    └── CalculatorServiceDemo/      # Core Project directory
        ├── Services/
        │   └── CalculatorService.cs # Calculator logic implementation
        ├── Program.cs              # Console Application Entry Point
        └── CalculatorServiceDemo.csproj # MSBuild Project file
```

---

## 🛠 Features

The `CalculatorService` provides the following operations:

| Method | Parameters | Return Type | Description |
| :--- | :--- | :--- | :--- |
| `Add` | `int a`, `int b` | `int` | Returns the sum of `a` and `b`. |
| `Subtract` | `int a`, `int b` | `int` | Returns the difference of `a` minus `b`. |
| `Multiply` | `int a`, `int b` | `int` | Returns the product of `a` and `b`. |
| `Divide` | `int a`, `int b` | `double` | Returns the quotient of `a` divided by `b`. Throws a `DivideByZeroException` if `b` is `0`. |
| `IsPrime` | `int number` | `bool` | Returns `true` if the number is prime; otherwise, `false`. |

---

## 🚀 How to Build and Run

### Prerequisites
- Install [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)

### Run the Application
Since the project source is organized under the `src/` directory, you can run the console application from the root directory using the `--project` flag:

```bash
dotnet run --project src/CalculatorServiceDemo
```

Alternatively, navigate into the project directory and run it directly:

```bash
cd src/CalculatorServiceDemo
dotnet run
```

### Build the Project
To compile the project without running it, use:

```bash
dotnet build
```

---

## 💻 Example Usage

Here is how the service is consumed in `Program.cs`:

```csharp
using CalculatorServiceDemo.Services;

var service = new CalculatorService();

// Adds 10 and 5 and outputs the result
Console.WriteLine(service.Add(10, 5)); // Output: 15
```
