// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//Решение на семинаре
// int [] CreateArray()
// {
//     Random random = new Random();
//     int[] numbers = new int[8];
//     System.Console.Write("Массив:");
//     for (int x = 0; x < numbers.Length; x++)
//     {
//         {
//             numbers[x] = random.Next(0, 2);
            
//         }
//     }
//     return numbers;

// }

// void PrintArray(int [] numbers)
// {
//     for (int x = 0; x < numbers.Length; x++)
//     System.Console.Write($" {numbers[x]}");
//     Console.WriteLine();
// }

// double Result(int [] numbers)
// {
//     double summ = 0;
//     for (int x = 0; x < numbers.Length; x++)
//     {
//         summ = summ + numbers[x];
    
//     }
//     return summ / 8;    
// } 


// int [] numbers = CreateArray();
// PrintArray(numbers);
// Console.WriteLine($"Среднне врифмитическое массива: {Result(numbers)}");

// int FillArray(int[] arrayRandom)
// {
//     int length = arrayRandom.Length;
//     int index = 0;
//     while (index < length)
//     {
//         arrayRandom[index] = new Random().Next(0, 2);
//         index++;
//     }
// }




// System.Console.Write("Введите размер массива: ");
// int arraySize = Convert.ToInt32(System.Console.ReadLine());
// FillArray(arrayRandom);
// Console.WriteLine();