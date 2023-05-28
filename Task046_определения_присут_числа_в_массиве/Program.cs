// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

void Search(int[] array, int num)
{
    foreach (int item in array)
        if (item == num)
        {
            System.Console.WriteLine("да");
            return;
        }
        else
            System.Console.WriteLine("нет");
}

int[] array = new int[4];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);

System.Console.WriteLine("введите проверяемое число");
int num = Convert.ToInt32(Console.ReadLine());

Search(array, num);