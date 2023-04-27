// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Второй способ с методом

void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("Это четверть 1");
    else if (x > 0 && y < 0)
        Console.WriteLine("Это четверть 4");
    else if (x < 0 && y < 0)
        Console.WriteLine("Это четверть 3");
    else if (x < 0 && y < 0)
        Console.WriteLine("Это четверть 2");
    else
        Console.WriteLine("Точка лежит на координатной оси");
}




Console.WriteLine("Введите коррдинату X: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коррдинату Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
CheckKoord(x1, y1);