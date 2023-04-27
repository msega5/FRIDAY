// На входе число любой разрядности. Надо вывести третью справа цифру 56899 -> 8

Console.WriteLine("Введите число");
long num = Convert.ToInt64(Console.ReadLine());
long result = 0;
if (num < 100)
{
    Console.WriteLine("Неверное число. Введите трёхзначное число");
}
else
{
    result = (num / 100) % 10;
}
Console.WriteLine(result);