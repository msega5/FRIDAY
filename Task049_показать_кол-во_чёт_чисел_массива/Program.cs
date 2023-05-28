// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] FindEven(int[] array)
{
    int count = 0;
    foreach (int item in array)
        if (item % 2 == 0)
            count++;
    int[] result = { count };
    return result;
}




Console.Clear();
int[] array = new int[4];
FillArray(array);
System.Console.Write("Сгенерировался такой массив: ");
PrintArray(array);
int[] rez = FindEven(array);
System.Console.WriteLine($"Количество чётных элементов = {rez[0]}");