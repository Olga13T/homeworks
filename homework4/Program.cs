// Домашнее задание к семинару 4
// Console.Clear();

//задача 25
// написать цикл, который принимает
// на вход - 2 числа (А и В) 
//на выходе - возводит А в степень В

int A = 2, B = 4, result = 1;
Console.WriteLine($"Число {A} в степени {B} равно: ");
result = Convert.ToInt32(Math.Pow(A, B));
Console.WriteLine(result);





//задача 27
// на входе - число 
// на выходе - сумма цифр в числе

// Console.WriteLine("Введите число:  ");
// int a = Convert.ToInt32(Console.ReadLine());
// int ostA = 0, sumA = 0, count = 0;
// Console.WriteLine();
// while (a > 0)
// {
//  ostA = a%10;
//  a = a / 10;
//  sumA = sumA + ostA;
//  count++;
// }
//  Console.WriteLine(sumA);


//задача 29
// программа задает массив из 8 элементов 
// на выходе - выводит элементы на экран

// int[] mass = new int[8];
// for (int i = 0; i < mass.Length; i++)
// {
//     mass[i] = new Random(). Next(0, 100);
//     Console.Write($"{mass[i]}  ");
// }
