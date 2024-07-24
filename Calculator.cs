class Calculator : ICalculator
{
    private readonly ILogger logger;

    /// <summary>
    /// Инициализирует новый экземпляр класса Calculator с заданным логгером.
    /// </summary>
    /// <param name="logger">Логгер для записи информации о вычислениях.</param>
    public Calculator(ILogger logger)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Выполняет сложение двух чисел и логирует результат.
    /// </summary>
    /// <returns>Сумма двух чисел a и b.</returns>
    public double Add(double a, double b)
    {
        double result = a + b;
        logger.LogInfo($"Выполнено сложение: {a} + {b} = {result}");
        return result;
    }
}