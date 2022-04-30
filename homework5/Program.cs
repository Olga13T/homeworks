//Домашнее задание к семинару 5
// задача 34
// задать массив
// заполнить случайными 3х значными числами
// на выходе - количество четных чисел массиве
// [345 897 568 234]  -> 2

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < array.Length - 1; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.Write($"{array[length - 1]} ");
    Console.WriteLine();
}
int[] mass = new int[8];
FillArray(mass);
PrintArray(mass);
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] % 2 < 1) count = count + 1;
}
Console.Write($"Количество четных элементов массива: {count} ");



// задача 36
// задать массив, заполнить случайными  числами
// на выходе - сумма элементов, стоящих на нечетных позициях
// [3 7 23 12] -> 19
void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 30);
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < array.Length - 1; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.Write($"{array[length - 1]} ");
    Console.WriteLine();
}

int[] b = new int[7];
FillArray(b);
PrintArray(b);
int sum = 0;
for (int i = 0; i < b.Length; i++)
{
    if (i % 2 > 0) sum = sum + b[i];
}
  Console.Write(sum);



// задача 38
// задать массив
// заполнить случайными числами
// на выходе - разница между max & min элементами в  массиве
// [3 7 22 2 78] -> 76

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int index = 0; index < array.Length - 1; index++)
    {
        Console.Write(array[index] + " ");
    }
    Console.Write($"{array[length - 1]} ");
    Console.WriteLine();
}

int[] mass = new int[5];
FillArray(mass);
PrintArray(mass);
Console.WriteLine();
int max = 0, min = 106, razMinMax = 0;
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] > max)
    {
        max = mass[i];
    }
}
for (int i = 0; i < mass.Length; i++)
{
    if (mass[i] < min)  min = mass[i];
}
razMinMax = max - min;
Console.WriteLine($"Разница между min значением- {min} и max - {max} равно: {razMinMax}");


