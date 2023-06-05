// Задача 65: Задайте значения M и N. Напишите программу,
//которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

string AllNumbers(int numN, int numM)
{
    if (numN == numM) return $"{numN}";// тумблер выключения
    return $"{AllNumbers(numN, numM - 1)}" + $", {numM}"; //суммирование и уменбшение счётчика на 1 
}




Console.Clear();
System.Console.Write("Введите целое число N и M: ");
int numN = Convert.ToInt32(System.Console.ReadLine());
int numM = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write(AllNumbers(numN, numM));