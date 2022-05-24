//Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(5, 100);
            array[i,j]=array[i,j]/10;
        }
    }
}
void Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] mass = new double[m, n];
FillArray(mass);
Print(mass);




// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void Fill(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            mass[i, j] = new Random().Next(20);
        }
    }
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] mass = new int[m, n];

Fill(mass);
Print(mass);
int[] save = new int[m * n];
Console.WriteLine("Введите позицию  массива начиная с 0: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > m * n)
{
    Console.Write($"Позиция {a} за пределами данного массива");
    return;
}
else
{
    int count = 0;
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            save[count] = mass[i, j];
            count++;
        }
    }
}
Console.WriteLine();
Console.Write($"Позиция -{a}-  {save[a]} ");


// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 6);
        }
    }
}
void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите число столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
Console.WriteLine();

for (int i = 0; i < mass.GetLength(1); i++)
{
    double result = 0;
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        result += mass[j, i];
    }

    Console.Write(result / mass.GetLength(0) + " ");
}



