// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] FindSumOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
            sum += array[i];
    }
    int[] result = { sum };
    return result;
}




Console.Clear();
int[] array = new int[4];
FillArray(array);
System.Console.Write("Сгенерировался такой массив: ");
PrintArray(array);
int[] rez = FindSumOdd(array);
System.Console.Write("Сумма элементов, стоящих на нечётных позициях: ");
System.Console.Write($"{array[1]} + {array[3]} = ");
System.Console.Write(rez[0]);