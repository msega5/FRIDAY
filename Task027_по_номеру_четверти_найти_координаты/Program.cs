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