// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Третий способ с возвратом

int CheckKoord(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0)
        result = 1;
    else if (x > 0 && y < 0)
        result = 4;
    else if (x < 0 && y < 0)
        result = 3;
    else if (x < 0 && y < 0)
        result = 2;
    return result;
}




Console.WriteLine("Введите коррдинату X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коррдинату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
CheckKoord(x, y);
int rez = CheckKoord(x, y);
Console.WriteLine($"Это четверть № {rez}");