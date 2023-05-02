// Задача 19.
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Compare1and5(int num)
{
    bool res = false;
    if (num / 10000 == num % 10)
        res = true;
    return res;
}

bool Compare2and4(int num)
{
    bool res = false;
    if (num / 10 % 10 == num / 1000 % 10)
        res = true;
    return res;
}




Console.WriteLine("Привет! Это программа, которая проверяет, является ли число полиндромом");
Console.Write("Введите число пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result;
if (result = Compare1and5(num) & Compare2and4(num))
    Console.WriteLine($"Число {num} полиндром");
else Console.WriteLine($"Число {num} НЕ полиндром");
