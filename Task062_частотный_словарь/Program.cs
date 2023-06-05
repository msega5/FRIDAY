// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] Quant(int[,] array)
{
    int[] arrayOne = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            // if(array[i,j]==0)
            // arrayOne[0]++;
            // if(array[i,j]==1)
            // arrayOne[1]++;
            // if(array[i,j]==2)
            // arrayOne[2]++;
            // if(array[i,j]==3)
            // arrayOne[3]++;

            arrayOne[array[i, j]]++;
        }
    }
    return arrayOne;
}

void PrintAr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
            System.Console.WriteLine($"В данном массиве число {i} встречается: {array[i]} раз");

    }
}

// int[] CountPosition(int[,] array)
// {
//     int[] count = new int[10];

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         for (int k = 0; k < count.Length; k++)
//         {
//             if (k == array[i, j])
//                 {count[k]++;
//                 k++;}  
//         }

//     }
//     return count;

// }
Console.Clear();
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
int[] myarray = Quant(array);
PrintAr(myarray);