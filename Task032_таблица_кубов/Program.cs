// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int sqr3(int i)
{
    return Convert.ToInt32(Math.Pow(i, 3));
}




Console.WriteLine("Привет! Эта программа выдаёт таблицу кубов чисел от 1 до N");
Console.Write("Введите число: N = ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"Для числа от 1 до {num} получилась следующая таблица кубов: ");
for (int i = 1; i < num; i++)
{
    Console.Write($"{sqr3(i)}, ");
}
Console.Write($"{sqr3(num)}");