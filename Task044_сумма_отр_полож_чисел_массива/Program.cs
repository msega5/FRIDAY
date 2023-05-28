// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из 
// промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

void FillArray(int[] array)
{
    for (int i =0; i<array.Length;i++)
        array[i] = new Random().Next(-9,10);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}

int[] FindSums(int[] array)
{
    int sum_p=0;
    int sum_n=0;
    foreach (int item in array)
        if (item>0)
            sum_p+=item;
        else    
            sum_n+=item;
    int[] result = {sum_p,sum_n};
    return result;
}


Console.Clear();
int [] array = new int[12];
FillArray(array);
System.Console.WriteLine("Сгенерировался такой массив");
PrintArray(array);
int [] rez = FindSums(array);
//PrintArray(FindSums(array));
System.Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
System.Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");