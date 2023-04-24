// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);
Console.WriteLine($"Было сгенерировано число {num}");
//Console.WriteLine("Было сгенерировано число" +num"); второй способ
int num1 = num / 10;
int num2 = num % 10;
if (num1 > num2)
    Console.WriteLine($"Наибольшее число {num1}");
else if (num2 > num1)
    Console.WriteLine($"Наибольшее число {num2}");
else
    Console.WriteLine($"Числа равны");

//Цикл for вывод чисел массива
for (int i = 1; i <= num; i = i + 3)
    Console.Write($"{i} ");