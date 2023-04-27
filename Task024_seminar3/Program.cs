// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Простой способ

// Console.WriteLine("Введите коррдинату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коррдинату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
//     Console.WriteLine("Это четверть 1");
// else if (x > 0 && y < 0)
//     Console.WriteLine("Это четверть 4");
// else if (x < 0 && y < 0)
//     Console.WriteLine("Это четверть 3");
// else if (x < 0 && y < 0)
//     Console.WriteLine("Это четверть 2");
// else
//     Console.WriteLine("Точка лежит на координатной оси");


//Второй способ с методом
// void CheckKoord(int x, int y)
// {
//     if (x > 0 && y > 0)
//         Console.WriteLine("Это четверть 1");
//     else if (x > 0 && y < 0)
//         Console.WriteLine("Это четверть 4");
//     else if (x < 0 && y < 0)
//         Console.WriteLine("Это четверть 3");
//     else if (x < 0 && y < 0)
//         Console.WriteLine("Это четверть 2");
//     else
//         Console.WriteLine("Точка лежит на координатной оси");
// }




// Console.WriteLine("Введите коррдинату X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коррдинату Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x1, y1);


//Третий способ с возвратом
// int CheckKoord(int x, int y)
// {
//     int result = 0;
//     if (x > 0 && y > 0)
//         result = 1;
//     else if (x > 0 && y < 0)
//         result = 4;
//     else if (x < 0 && y < 0)
//         result = 3;
//     else if (x < 0 && y < 0)
//         result = 2;
//     return result;
// }




// Console.WriteLine("Введите коррдинату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите коррдинату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// CheckKoord(x, y);
// int rez = CheckKoord(x, y);
// Console.WriteLine($"Это четверть № {rez}");






// Напишите программу, которая по заданному номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).

string CheckKoord(int num)
{
    string result = "";
    if (num == 1)
        result = "x > 0, y > 0";
    else if (num == 2)
        result = "x < 0, y > 0";
    else if (num == 3)
        result = "x < 0, y < 0";
    else if (num == 4)
        result = "x > 0, y < 0";
    return result;
}



try
{
    Console.WriteLine("Введите номер четверти от 1 до 4: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string rez = CheckKoord(num);
    if (rez != "")
        Console.WriteLine($"Координаты могут быть {CheckKoord(num)}");
    else
        Console.WriteLine("Были введены некорректные данные");
}
catch
{
    Console.WriteLine("Надо было вводить целые числа");
}