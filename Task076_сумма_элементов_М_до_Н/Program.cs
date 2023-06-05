// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummNumbers(int numM, int numN, int summ)
{
    if (numM == numN) return summ + numM;
    return summ += SummNumbers(numM, numN - 1, summ) + numN;
}




Console.Clear();
int summ = 0;
System.Console.Write("Введите целое число M: ");
int numM = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите целое число N: ");
int numN = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write($"Сумма натуральных элементов в промежутке от {numM} до {numN} = ");
System.Console.Write(SummNumbers(numM, numN, summ));