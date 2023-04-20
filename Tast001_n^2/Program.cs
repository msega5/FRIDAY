// Напишите программу, которая на вход принимает число и выдает его квадрат
//  (число умноженное  на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int result = num * num;
Console.WriteLine(result);
if (num > 0)
{
    Console.WriteLine("Было введено положительное число");
}
else if (num == 0)
    Console.WriteLine("Был введен ноль");
else
    Console.WriteLine("Было введено отрицательное число");