// Задача 69: Напишите программу, которая на вход принимает
//два числа A и B, и возводит число А в целую степень B
//с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int AinB(int numA, int numB)
{
    if (numB == 0) return 1;// тумблер выключения
    return num * AinB; //суммирование и уменьшение счётчика на 1 
}




Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write(SummNum(num));