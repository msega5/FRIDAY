// Посчитать сумму целых чисел от 1 до N.
// Где N вводитися пользователем

int Summa(int num)
{
    int res = 0;
    while (true)
    {
        res += num;
        num--;
        if (num == 0)
            break;
    }
    return res;
}

int SummaRec(int num)
{
    if (num == 0)  return 0;// тумблер включения
    return num + SummaRec(num - 1); //суммирование и уменбшение счётчика на 1 
}




Console.Clear();
System.Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Искомая сумма равна {Summa(num)}");
System.Console.WriteLine($"Искомая сумма рекурсии равна {Summa(num)}");
