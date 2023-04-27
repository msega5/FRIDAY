// Задача необязательная 1: на входе целое или вещественное число, надо удалить вторую цифру слева этого числа.
// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.WriteLine("Привет! Это программа, которая удаляет вторую цифру заданного числа целого или вещественного");
Console.Write("Введите число: ");
double num = Convert.ToDouble(Console.ReadLine());
int numInt = Convert.ToInt32(num);
double numReal = 0;
int numIntRes = 0;
int sign = 1;

if (num < 0) //Добавил проверку на отрицательные числа
{
    sign = (-1);
    num = num * sign;
    numInt = numInt * sign;
}

numReal = num - numInt; //Находим дробную часть
Console.WriteLine($"Число {num * sign} это целая часть {numInt * sign} + {Math.Round(numReal, 10)}"); //Вспомогательная информация для отображения состава числа

if (num < 10)
    Console.WriteLine($"Введите число побольше!");
else
{
    //Поиск и удаление второй цифры числа (задача из семинара 2)
    int count = 0;
    int i = numInt;
    while (i > 0)
    {
        count++;
        i = i / 10;
    }
    numIntRes = numInt / (Convert.ToInt32(Math.Pow(10, count - 1))) *
                    (Convert.ToInt32(Math.Pow(10, count - 2))) +
                    numInt % (Convert.ToInt32(Math.Pow(10, count - 2)));
    //Вывод числа
    Console.WriteLine($"Получается число: {sign*(numIntRes + Math.Round(numReal, 10))}");
}
