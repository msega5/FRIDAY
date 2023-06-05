// Задача 67: Напишите программу, которая будет принимать
//на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


int SummNum(int num)
{
    if (num == 0) return 0;// тумблер выключения
    return num % 10 + SummNum(num / 10); //суммирование и уменьшение счётчика на 1 
}




Console.Clear();
System.Console.Write("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write(SummNum(num));