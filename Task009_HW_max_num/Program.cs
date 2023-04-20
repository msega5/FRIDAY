// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Привет! Эта программа сравнивает три числа и выдаёт максимальное");
Console.WriteLine("Введите три числа: ");
int num1, num2, num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num2 < max)
{
    max = num1;
}
else max = num2;

if (num3 < max)
{
    max = num1;
}
else max = num3;

Console.WriteLine($"Максимальное число {max}");