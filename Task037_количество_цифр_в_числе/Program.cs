// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int Sum(int num)
{
    int result = 0, i = 1;
    while (num > 0)
    {
        num = num / 10;
        result = result + i;
    }
    return result;
}




try
{
    System.Console.WriteLine("Введите натуральное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"Количество цифр в числе {num} равно {Sum(num)}");
}
catch
{
    System.Console.WriteLine("Повторите ввод");
}

//Доделать с нулём



// int Result(int x)
// {
//     int count = 0;

//     while (x > 0)
//     {
//         x = x / 10;
//         count++;
//     }
//     return count;
// }

// System.Console.WriteLine("Введите любое число");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Колличество цифр в числе: {Result(num)}");