// Задача 58: Задайте две матрицы. Напишите программу,
//которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 4);
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

void ProductOfArray(int[,] arrayOne, int[,] arrayTwo, int[,] arrayRes)
{
    for (int i = 0; i < arrayOne.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            for (int k = 0; k < arrayTwo.GetLength(0); k++)
            {
                arrayRes[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
            System.Console.Write($"{arrayRes[i, j],3}\t");
        }
        System.Console.WriteLine();
    }
}




Console.Clear();
System.Console.Write("Введите размер массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
int[,] arrayOne = new int[rows, rows];
int[,] arrayTwo = new int[rows, rows];
int[,] arrayRes = new int[rows, rows];
FillArray(arrayOne);
FillArray(arrayTwo);
System.Console.WriteLine("Исходный массив One: ");
PrintArray(arrayOne);
System.Console.WriteLine("Исходный массив Two: ");
PrintArray(arrayTwo);
System.Console.WriteLine("Результирующая матрица будет: ");
ProductOfArray(arrayOne, arrayTwo, arrayRes);