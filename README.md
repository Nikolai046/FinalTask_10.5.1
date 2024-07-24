# Простой калькулятор с логированием

## Особенности

- Выполнение арифметических операций по сложению 2 чисел
- Логирование операций и ошибок
- Обработка пользовательского ввода
- Обработка исключений

## Структура проекта

Проект состоит из следующих основных компонентов:

1. `ICalculator` - интерфейс для калькулятора
2. `Calculator` - реализация калькулятора
3. `ILogger` - интерфейс для логгера
4. `Logger` - реализация логгера
5. `Program` - основной класс приложения

## Обработка ошибок

Приложение обрабатывает следующие исключения:
- FormatException: когда введено некорректное значение
- OverflowException: когда введенное число слишком большое или маленькое
- Другие непредвиденные исключения
