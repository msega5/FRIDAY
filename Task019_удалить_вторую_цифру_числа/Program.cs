// На входе от пользователя целое число любой разрядности,
// надо удалить вторую слева цифру этого числа

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int i = num;
while (i > 0)
{
    count++;
    i = i / 10;
}
int res = num / (Convert.ToInt32(Math.Pow(10, count - 1))) *
                (Convert.ToInt32(Math.Pow(10, count - 2))) +
                num % (Convert.ToInt32(Math.Pow(10, count - 2)));

Console.WriteLine(res);
