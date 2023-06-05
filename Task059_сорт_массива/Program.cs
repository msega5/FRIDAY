// Задача HARD SORT необязательная. Считается за три
//обязательных
// Задайте двумерный массив из целых чисел.
//Количество строк и столбцов задается с клавиатуры.
//Отсортировать элементы по возрастанию слева направо и сверху
//вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 20);
}

void PrintArray(int[,] array)
{
    System.Console.WriteLine("Исходный массив:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}\t");
        System.Console.WriteLine();
    }
}

// void SortString(int i, int j, int[,] array)
// {
//     int max = array[0, 0];

// }

int SortArray(int[,] array)
{
    // int num1 = array[0, 0];
    // int num2 = array[0, 1];
    // int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(0) - 1; k++)
            {
                
            }
            FOR J=0 TO N-1 STEP 1
   F=0
   MIN=J
   FOR I=J TO N-1-J STEP 1 
     IF Y[I]>Y[I+1] THEN SWAP Y[I],Y[I+1]:F=1
     IF Y[I]<Y[MIN] THEN MIN=I
   NEXT I
   IF F=0 THEN EXIT FOR
   IF MIN<>J THEN SWAP Y[J],Y[MIN]
 NEXT J
            if (num1 > num2)
            {
                temp = num2; //temp = array[0,1]
                num2 = num1; //array[0,1] = array[0,0]
                num1 = temp; //array[0,0] = temp
            }
            else
                num2 = array[i, j + 1];
        }
    //int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    return new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
}

Console.Clear();

System.Console.WriteLine("Программа для сортировки массива от меньшего к большему");

System.Console.Write("Введите число строк массива: ");
int rows = Convert.ToInt32(System.Console.ReadLine());

System.Console.Write("Введите число столбцов массива: ");
int cols = Convert.ToInt32(System.Console.ReadLine());

int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
SortArray(array);
PrintArray(array);