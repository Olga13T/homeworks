// Домашнее задание к 3у семинару
// Задача 19
// на входе - 5значное число
// на выходе  - проверяет палиндром или нет
// 14212 - нет
// 23432 - да
// 12821 - да

// Console.Clear();
int a = 12821;
Console.WriteLine(a);
 int b = a / 10000, c = a%10, d = a / 1000, e = d%10, f = a / 10, g = f%10;
//Console.WriteLine($"первая цифра - {b}, вторая {e}, четвертая {g}, пятая {c}");
if(b == c & e == g)
{
    Console.WriteLine($"Число {a}  - является палиндромом.");
}
else
{
     Console.WriteLine($"Число {a}  - не является палиндромом.");
}







// Задача 21
// на входе - координаты 2х точек
// на выходе  -  находит расстояние между ними
// ! в 3D пространстве
A(3,6,8); B(2,1,-7) -> 15.84
A(7,-5,0); B(1,-1,9) -> 11.53
 int x1 = 7, y1 = -5, z1 = 0, x2 = 1, y2 = -1, z2 = 9;

double lenght = Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2) + Math.Pow(z1-z2,2));
Console.WriteLine(lenght);


// Задача 23
// на входе - число N
// на выходе  - таблица кубов от 1 до N

Console.Clear();

Console.WriteLine("Введите число: ");
int N =  Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"кубы от 1 до {N}");
Console.WriteLine();

    for(int j = 1; j <= N; j++)
    {
        Console.WriteLine($"{j} в кубе: {j*j*j} ");
    }
        Console.WriteLine();

