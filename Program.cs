// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

Console.WriteLine("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

void Rec(int n, int m)
{
    if (n < m )
        return;
    Rec(n - 1, m);
    Console.Write(n + " ");
}
Rec(n, m);



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());

int Rec(int n, int m)
{
        if (n < m) return 0;
    if (m <= n) return m + (Rec(n, m + 1));

    n = n - 1;
    return m + (Rec(n, m + 1));

}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равна -  {Rec(n, m)}  ");





// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите число M:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:  ");
int n = Convert.ToInt32(Console.ReadLine());
int Akker(int m, int n)
{
    if (m == 0)
    {
        if (n == 0) return 1;
        if (n > 0) return n + 1;
        else return 0;
    }
    if (m == 1) return n + 2;
    if (m == 2) return 2 * n + 3;
    if (m == 3) return (int)Math.Pow(m - 1, n + 3) - 3;
    if (m > 3)
    {
        while (n > 0)
        {
            n--;
            return Akker(m - 1, Akker(m, n));
        }
        if (n == 0) return Akker(m - 1, 1);
    }
    if (m < 0) return 0;
    else
    {
        return 404;
    }
}
Akker(m, n);
Console.Write(Akker(m, n));
