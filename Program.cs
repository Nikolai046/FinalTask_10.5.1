using System;

interface ICalculator
{
    double Add(double a, double b);
}

interface ILogger
{
    void LogInfo(string message);
    void LogError(string message);
}

class Calculator : ICalculator
{
    private readonly ILogger _logger;

    public Calculator(ILogger logger)
    {
        _logger = logger;
    }

    public double Add(double a, double b)
    {
        double result = a + b;
        _logger.LogInfo($"Выполнено сложение: {a} + {b} = {result}");
        return result;
    }
}

class ConsoleLogger : ILogger
{
    public void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"INFO: {message}");
        Console.ResetColor();
    }

    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ERROR: {message}");
        Console.ResetColor();
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        ICalculator calculator = new Calculator(logger);

        try
        {
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = calculator.Add(num1, num2);
            Console.WriteLine($"Результат: {result}");
        }
        catch (FormatException)
        {
            logger.LogError("Введено некорректное значение. Пожалуйста, введите числа.");
        }
        catch (OverflowException)
        {
            logger.LogError("Введенное число слишком большое или слишком маленькое.");
        }
        catch (Exception ex)
        {
            logger.LogError($"Произошла неожиданная ошибка: {ex.Message}");
        }
        finally
        {
            logger.LogInfo("Программа завершена.");
        }
    }
}