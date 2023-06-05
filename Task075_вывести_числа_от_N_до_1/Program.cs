﻿// Задача 64: Задайте значение N. Напишите программу,
//которая выведет все натуральные числа в промежутке
//от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string RowOfNumbers(int num)
{
    if (num == 1) return $"{num}";
    return $"{num}, " + $"{RowOfNumbers(num - 1)}";
}



Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write(RowOfNumbers(num));