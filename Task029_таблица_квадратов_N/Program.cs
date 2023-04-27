// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите любое число:");
int num_max = Convert.ToInt32(Console.ReadLine());
int num_min = 1;
double resault = 0;
while (num_min <= num_max)
{
    resault = (Math.Pow(num_min,2));
    Console.Write($" {resault}");
    num_min++;
}