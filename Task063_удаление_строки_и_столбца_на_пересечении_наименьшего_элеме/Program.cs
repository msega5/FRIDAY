// Задача 59: Задайте двумерный массив из целых чисел.
//Напишите программу,
//  которая удалит строку и столбец,
//на пересечении которых расположен наименьший элемент
//массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] MinIndex(int[,] array)
{
    int[] minimum = new int[3];
    int min = array[0, 0];
    int Imin = 0;
    int Jmin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                Imin = i;
                Jmin = j;
            }
            minimum[0] = min;
            minimum[1] = Imin;
            minimum[2] = Jmin;
        }
    }
    return minimum;
}

int[,] ArrayTwo(int[,] array, int I, int J)
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != I && j != J)
            {
                newArray[i,j]= array[i,j];
            }
        }
    }
    return newArray;

}

// void PrintAr(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {

//             System.Console.Write(array[i] );

//     }
//     System.Console.WriteLine();
// }


Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
int[] min = MinIndex(array);
// PrintAr(min);
int[,] newArray = ArrayTwo(array,min[1],min[2]);