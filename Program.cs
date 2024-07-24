using System;

class Program
{
    /// <summary>
    /// Точка входа в программу. Инициализирует калькулятор, запрашивает ввод чисел,
    /// выполняет сложение и обрабатывает возможные исключения.
    /// </summary>
    static void Main()
    {
        ILogger logger = new Logger();
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