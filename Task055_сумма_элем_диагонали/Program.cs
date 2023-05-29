// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0,0); (1;1) и отдельно сумму элементов
// обратной диагонали
// Например, задан массив:
// 1 4 7 
// 5 9 2 
// 8 4 2 
// Сумма элементов главной диагонали: 1+9+2 = 12
// сумма элементов обратной диагонали 8 + 9 + 7 = 24


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-30, 30);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

int SummMainDiagArray(int[,] array)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
                summ += array[i, j];
    return summ;
}

int SummReversDiagArray(int[,] array, int rows)
{
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            if (i + j == rows - 1)
                summ += array[i, j];
    return summ;
}



Console.Clear();
Console.Write("Введите размер массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, rows];             //так как массив имеет диагонали, cols не нужны
Console.WriteLine("Исходный массив:");
FillArray(array);
PrintArray(array);
SummMainDiagArray(array);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали (с индексами (0,0) (1;1) и т.д.) равно: {SummMainDiagArray(array)}");
SummReversDiagArray(array, rows);
Console.WriteLine($"Сумма элементов, находящихся на обратной диагонали (с индексами (0,2) (1;1) и т.д.) равно: {SummReversDiagArray(array, rows)}");