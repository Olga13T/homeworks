// Домшанее задание к семинару 6

// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите число: ");
string str = Console.ReadLine();
Console.WriteLine();
string[] array = str.Split(",");
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    int number = int.Parse(array[i]);
    if (number > 0) count = count + 1;
}
    Console.WriteLine($"количество положительных чисел: {count}");



// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
// y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2:  ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1:  ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2:  ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"b1 = 2, b2 = 4, k1 = 5, k2 =9 ");
Console.WriteLine();

double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;

Console.Write($"Координаты точки пересечения равны x: {x} y: {y}");






