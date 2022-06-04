// Homework8
// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 45);
            array[i, j] = array[i, j];
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
    Console.WriteLine();
}

int m = 5, n = 9;
int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
void SelectionMax(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            int maxPosition = j;
            for (int k = j + 1; k < array.GetLength(1) ; k++)
            {
                if (array[i, k] > array[i, maxPosition])
                {
                    maxPosition = k;
                }
            }
            int temporary = array[i, maxPosition];
            array[i, maxPosition] = array[i, j];
            array[i, j] = temporary;
        }
    }
}
Console.WriteLine();
SelectionMax(mass);
Print(mass);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 7);
            array[i, j] = array[i, j];
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

int m = 3, n = 4;
int[,] mass = new int[m, n];
FillArray(mass);
Print(mass);
int summ = 0;
int minSumm = 199;
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        summ = summ + mass[i, j];    
    }
    // Console.Write(summ);
    if (summ < minSumm)
    {
        minSumm = summ;
        summ=0;
    } 
 }
Console.Write($"Строка с наименьшей суммой равна - {minSumm}");






// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

void Fill(int[,,] massT)
{
    for (int i = 0; i < massT.GetLength(0); i++)
    {
        for (int j = 0; j < massT.GetLength(1);)
        {
            bool old = false;
            for (int g = 0; g < massT.GetLength(2); g++)
            {
                int newRandom = new Random().Next(1, 100);
                if (massT[i, j, g] == newRandom)
                {
                    old = true;
                    break;
                }
                if (!old)
                    massT[i, j, g] = new Random().Next(1, 100);
            }
            j++;
        }
    }
}
void Print(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int g = 0; g < mass.GetLength(2); g++)
            {
                Console.Write(mass[i, j, g] + " ");
            }
        }
        Console.WriteLine();
    }
}
int m = 3, n = 3, l = 2;
int[,,] newMass = new int[m, n, l];

Fill(newMass);
Print(newMass);
Console.WriteLine();
