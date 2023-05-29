// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int mathDegree(int numA, int numB)
{
    int res = 0;
    res = numA;
    return res;
}




System.Console.WriteLine("Это программа, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B");
System.Console.Write("Введите число A = ");
int numA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число B = ");
int numB = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Ответ: {mathDegree(numA, numB)}");