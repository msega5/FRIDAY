// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] FindMaxMin(int[] array)
{
    int max = array[0];
    int min = array[1];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    int[] result = { max, min };
    return result;
}

int[] FindMin(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    int[] result = { min };
    return result;
}




Console.Clear();
int[] array = new int[4];
FillArray(array);
System.Console.Write("Сгенерировался такой массив: ");
PrintArray(array);
int[] rez = FindMaxMin(array);
int difference = rez[0] + rez[1];
if (rez[1] > 0)
{
    difference = rez[0] - rez[1];
}
else
{
    difference = rez[0] + rez[1];
}
System.Console.WriteLine($"Разница между максимальным {rez[0]} и минимальным {rez[1]} элементами массива = {difference}");