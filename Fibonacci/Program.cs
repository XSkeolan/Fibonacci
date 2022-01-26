Console.Write("Конечное число: ");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Невозможно пропарсить число или оно слишком большое\nВведите другое число");
    continue;
}

Fibonacci(a, OutputType.Console); 


static int Fibonacci(int endNumber, OutputType type)
{
    int current = 0;
    int prev1 = 0;
    int prev2 = 1;
    while (current <= endNumber)
    {
        Console.WriteLine(current);
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