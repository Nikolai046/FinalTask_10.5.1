class Logger : ILogger
{
    // <summary>
    /// Логирует информационное сообщение синим цветом в консоль.
    /// </summary>
    /// <param name="message">Текст информационного сообщения.</param>
    public void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"СООБЩЕНИЕ: {message}");
        Console.ResetColor();
    }

    /// <summary>
    /// Логирует сообщение об ошибке красным цветом в консоль.
    /// </summary>
    /// <param name="message">Текст сообщения об ошибке.</param>
    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"ОШИБКА: {message}");
        Console.ResetColor();
    }
}