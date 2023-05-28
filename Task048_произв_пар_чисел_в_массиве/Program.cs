// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] MultiArray(int[] array)
{

    int[] result = new int[array.Length / 2 + array.Length % 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
        result[^1] = array[array.Length / 2];
    return result;

}




Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
PrintArray(MultiArray(array));