﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Привет! Это программа определяет проверяет, является ли этот день выходным");
Console.Write("Введите цифру от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 1 ^ day > 7)
    Console.WriteLine("Всё-таки введите цифру от 1 до 7: ");
else
if (day == 6 ^ day == 7)
    Console.WriteLine("Да, это выходной день");
else Console.WriteLine("Нет, это будний день");