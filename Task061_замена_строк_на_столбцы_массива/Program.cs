// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами
// первую и последнюю строку массива.

// Задача 55: Задайте двумерный массив.
// Напишите программу, которая заменяет строки на
// столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            (array[i, j], array[j, i])
          = (array[j, i], array[i, j]);
        }
    }
}




Console.Clear();
System.Console.Write("Введите размер массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
int[,] array = new int[rows, rows];
FillArray(array);
PrintArray(array);
ChangeArrayString(array);
PrintArray(array);