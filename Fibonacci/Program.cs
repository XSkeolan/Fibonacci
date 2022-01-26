Console.Write("Конечное число: ");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Невозможно пропарсить число или оно слишком большое\nВведите другое число");
    continue;
}

Console.WriteLine("Выберите вид вывода результатов:\n\t1: Консоль\n\t2: Файл");
switch (Console.ReadKey(true).KeyChar)
{
    case '1':
        Fibonacci(a, OutputType.Console);
        break;
    case '2':
        {
            Fibonacci(a, OutputType.File);
            Console.WriteLine("Последовательность Фибоначчи сохранена в файл {0}\\fibo.txt", Environment.CurrentDirectory);
            break;
        }
}

 


static int Fibonacci(int endNumber, OutputType type)
{
    int current = 0;
    int prev1 = 0;
    int prev2 = 1;
    using var writer = type == OutputType.File ? new StreamWriter("fibo.txt") : null;
    while (current <= endNumber)
    {
        if (writer == null)
            Console.WriteLine(current);
        else
            writer.Write(current + " ");
        current = prev1 + prev2;
        prev1 = prev2;
        prev2 = current;
    }
    return current;
}

public enum OutputType
{
    Console,
    File
}