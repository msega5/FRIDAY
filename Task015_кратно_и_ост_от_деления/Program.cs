// Напишите программу, которая будет принимать
// на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int ost = num1 % num2;
if (ost == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine($"Не кратно остаток {ost}");
}

//Второй вариант
// Console.WriteLine("Введите 2 числа"); 
// int num1 = Convert.ToInt32(Console.ReadLine()); 
// int num2 = Convert.ToInt32(Console.ReadLine()); 
// int div = num1 % num2; 
// if( div == 0) 
//     Console.WriteLine("Число кратно"); 
// else 
//     Console.WriteLine($"Число не кратно, остаток от деления =  {div}");