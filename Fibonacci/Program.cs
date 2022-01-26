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

    Console.Write(0 + " ");
    int sum = 1;
    int prev = 0;
    int next = 1;

    while (c > sum)
    {
        Console.Write(sum + " ");
        sum = prev + next;
        
        prev = next;
        next = sum;
    }
    return sum;
}
