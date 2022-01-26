Console.Write("Конечное число: ");
int a;
while (!int.TryParse(Console.ReadLine(), out a))
{
    continue;
}
Fibonacci(a); 


static int Fibonacci(int c)
{
    if (c == 0)
    {
        Console.WriteLine(0);
        return 0;
    }
    if (c == 1 || c == 2)
    {
        Console.WriteLine(1);
        return 1;
    }

    int sum = 0;
    int prev = 1;
    int next = 1;

    while (c > sum)
    {
        sum = prev + next;
        Console.Write(sum + " ");
        prev = next;
        next = sum;
    }
    return sum;
}
