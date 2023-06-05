// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 20);
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}\t");
        System.Console.WriteLine();
    }
}

void ChangeArrayString(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        (array[0, j], array[array.GetLength(0) - 1, j]) = (array[array.GetLength(0) - 1, j], array[0, j]);
    }
}




Console.Clear();
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(System.Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
ChangeArrayString(array);
PrintArray(array);