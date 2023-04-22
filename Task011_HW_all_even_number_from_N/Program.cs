// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Привет! Это программа, которая показывает все чётные числа от 1 до N");
Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.Write($"При N = {numN} получился такой ряд чисел: ");
for (int index = 1; index < numN + 1; index++)
{
    if (index % 2 == 0)
    {
        Console.Write($" {index}");
    }
}