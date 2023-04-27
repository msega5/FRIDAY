

















// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21







// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4




Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

double Rast(double x1, double y1, double x2, double y2)
{
return Math.Sqrt((Math.Pow(x2 - x1,2)) + (Math.Pow(y2 - y1,2)));
}


Console.WriteLine("Введите Координату x1 для точки А");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату y1 для точки А");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату x2 для точки B");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите Координату y2 для точки B");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(Rast(x1,y1,x2,y2),3)}");

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4

Console.WriteLine("Введите любое число:");
int num_max = Convert.ToInt32(Console.ReadLine());
int num_min = 1;
double resault = 0;
while (num_min <= num_max)
{
    resault = (Math.Pow(num_min,2));
    Console.Write($" {resault}");
    num_min++;
}