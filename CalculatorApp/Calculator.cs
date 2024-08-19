using Microsoft.Extensions.Logging;

namespace CalculatorApp;

public class Calculator
{
    private readonly ILogger<Calculator> _logger;

    public Calculator(ILogger<Calculator> logger)
    {
        _logger = logger;
    }
    public double PerformOperation(double num1, double num2, string operation)
    {
        return operation switch
        {
            "add" => num1 + num2,
            "subtract" => num1 - num2,
            "multiply" => num1 * num2,
            "divide" => num2 == 0 ? throw new DivideByZeroException("Cannot divide by zero.") : num1 / num2, // Division by Zero
            _ => throw new UnsupportedOperationException("An error occurred: The specified operation is not supported.")
        };

    }

}

// Added custom exception for Unsupported Operation
public class UnsupportedOperationException : Exception
{
    public UnsupportedOperationException(string message) : base(message) {}
}