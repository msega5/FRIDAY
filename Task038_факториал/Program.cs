// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120




int factorial(int num)
{
    int res = 1;
    for (int i = 1; i < num + 1; i++)
    res = res * i;
    return res;
}




System.Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Ответ: {factorial(num)}");