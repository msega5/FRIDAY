//Ряд Фибоначчи

int Fib(int num)
{
    if (num == 2) return 1;
    if (num == 1) return 0;
    return Fib(num - 1) + Fib(num - 2);
}

void PrintFib(int num)
{
    for (int i = 1; i < num; i++)
        System.Console.Write($"{Fib(i)}, ");
    System.Console.WriteLine(Fib(num));
}


Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
PrintFib(num);