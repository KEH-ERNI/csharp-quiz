using Microsoft.Extensions.Logging;

namespace CalculatorApp;

public class Program
{
    static void Main(string[] args)
    {
        var logger = LoggerProvider.CreateLogger<Program>();
        try
        {
            double num1 = ReadDouble("Enter the first number:");
            double num2 = ReadDouble("Enter the second number:");

            Console.WriteLine("Enter the operation (add, subtract, multiply, divide):");
            string operation = Console.ReadLine()?.ToLower() ?? string.Empty;

            var calculator = new Calculator(LoggerProvider.CreateLogger<Calculator>());
            double result = calculator.PerformOperation(num1, num2, operation);
            Console.WriteLine($"The result is: {result}");

        }
        catch (FormatException) // Invalid Input (non-numeric value in any number)
        {
            logger.LogError("Invalid input. Please enter numeric values.");
        }
        catch (Exception ex) // Overall exception
        {
            logger.LogError($"{ex.Message}");
        }
        finally
        {
            logger.LogInformation("Calculation attempt finished.");
        }

    }

    public static double ReadDouble(string prompt)
    {
        Console.WriteLine(prompt);
        return Convert.ToDouble(Console.ReadLine());
    }

}