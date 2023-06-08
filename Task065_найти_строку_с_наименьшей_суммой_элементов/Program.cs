// Задача 56: Задайте прямоугольный двумерный массив.
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
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

int RowElementsSumm(int[,] array, int i)
{
    int summRow = array[i, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        summRow += array[i, j];
    }
    return summRow;
}




Console.Clear();
System.Console.Write("Введите размер массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());
int[,] array = new int[rows, rows];
FillArray(array);
System.Console.WriteLine("Исходный массив: ");
PrintArray(array);

int minRowSumm = 0;
int summ = RowElementsSumm(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int temp = RowElementsSumm(array, i);
    if (summ > temp)
    {
        summ += temp;
        minRowSumm = i;
    }
}

System.Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {minRowSumm + 1}");