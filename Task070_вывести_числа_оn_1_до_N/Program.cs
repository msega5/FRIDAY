// Задача 63: Задайте значение N.
// Напишите программу, которая выведет все натуральные
// числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

string AllNumbers(int num)
{
    if (num == 1) return $"{1}";// тумблер выключения
    return $"{AllNumbers(num - 1)}" + $", {num}"; //суммирование и уменбшение счётчика на 1 
}




Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write(AllNumbers(num));
