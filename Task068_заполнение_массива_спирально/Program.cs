// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// 01 02 03 04 05
// 16 17 18 19 06
// 15 24 25 20 07
// 14 23 22 21 08
// 13 12 11 10 09

void FillArray(int[,] array, int num)
{
    int k = 1;
    for (int i = 0; i < array.GetLength(0); i++){
        if (i != 0) continue;{
            for (int j = 0; j < array.GetLength(1); j++){
                array[i, j] = k;
                k++;
            }}}

    for (int i = 1; i < array.GetLength(0); i++){
        for (int j = 1; j < array.GetLength(1); j++){
            if (j != array.GetLength(1) - 1) continue;{
                array[i, j] = k;
                k++;
            }}}
    int l = k;
    for (int i = 0; i < array.GetLength(0); i++){
        if (i != array.GetLength(0) - 1) continue;{
            for (int j = 0; j < array.GetLength(1) - 1; j++){
                array[i, j] = l + i - 1;
                l--;
                k++;
            }}}  
    for (int i = 0; i < array.GetLength(0) - 1; i++){
        if (i != array.GetLength(0) - 1) continue;{
            for (int j = 0; j < array.GetLength(1); j++){
                if (j != 0) continue;{
                array[i, j] = k;
                k++;
            }}}}
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




Console.Clear();
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());
int[,] array = new int[num, num];
FillArray(array, num);
System.Console.WriteLine("Исходный массив: ");
PrintArray(array);