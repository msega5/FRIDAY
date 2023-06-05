// Задача 68: Напишите программу вычисления функции Аккермана
//с помощью рекурсии. Даны два неотрицательных числа m и n.
// n = 2, m = 3 -> A(n,m) = 9
// n = 3, m = 2 -> A(n,m) = 29

int Akk(int n, int m)
{
    if (n == 0)
    {
      //  System.Console.WriteLine($"Функция имеет вид: Akk({n}, {m})");
        return m + 1;
    }
    else if (n != 0 && m == 0)
    {
      //  System.Console.WriteLine($"Функция имеет вид: Akk({n}, {m})");
        return Akk(n - 1, 1);
    }
    else
    {
      //  System.Console.WriteLine($"Функция имеет вид: Akk({n}, {m})");
        return Akk(n - 1, Akk(n, m - 1));
    }

}




Console.Clear();
System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(System.Console.ReadLine());
Akk(n, m);
System.Console.WriteLine($"Результат вычисления функции: n = {n}, m = {m} -> Akk({n},{m}) = {Akk(n, m)}");
System.Console.ReadKey();