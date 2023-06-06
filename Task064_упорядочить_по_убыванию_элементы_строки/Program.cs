// Задача 54: Задайте двумерный массив. Напишите программу,
//которая упорядочит по убыванию элементы каждой строки
//двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 30);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}\t");
        System.Console.WriteLine();
    }

}

void SortMaxToMinInRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SortRow(i, j, array);
        }
        System.Console.Write("");
    }
}

void SortRow(int i, int j, int[,] array)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        if (array[i, j] < array[i, k]) continue;
        {
            int temp = 0;
            temp = array[i, k];
            array[i, k] = array[i, j];
            array[i, j] = temp;
        }
    }
}




Console.Clear();
System.Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int cols = Convert.ToInt32(System.Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
SortMaxToMinInRow(array);
System.Console.WriteLine("В итоге получается вот такой массив:");
PrintArray(array);