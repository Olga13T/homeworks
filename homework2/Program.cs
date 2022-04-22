// домашнее задание к Семинару 2

// 1 задача
// программа
// на входе - трехзначное число
// на выходе -  вторая цифра числа
// 456 ->5
// 782 -> 8
// 918 ->1

int a = 456, b = a%100, c = b / 10;

Console.WriteLine($"Средняя цифра числа {a}  -  число {c}");



// 2 задача
// программа
// на входе - случайное трехзначное число
// на выходе - удаляет 2ю цифру числа

Console.Clear();
int a = new Random(). Next(100, 1000);
int b = a / 100, c = a%10;
Console.WriteLine(a);
Console.WriteLine();

Console.WriteLine($"Число без средней цифры - {b}{c}");


// 3 задача
// программа
// на входе - число
// на выходе - 3я цифра числа либо надпись -"3ей цифры нет"

Console.Clear();
Console.WriteLine("Введите число от 100 до 999:  ");
int a = Convert.ToInt32(Console.ReadLine()), b = a%10;
if (a > 1000)
{
    Console.WriteLine($"Число {a} не отвечает заданным параметрам");
}
if (a < 100)
{
    Console.WriteLine($"У числа {a} нет 3-ей цифры");
}
if (a > 100 & a < 1000)
{
    Console.WriteLine($"У числа {a} последняя цифра равна {b}");
}

// 4 задача
// программа
// на входе - цифры обозначающие дни недели
// на выходе - сообщение выходной/будний день
Console.Clear();

int mon = 1, tue = 2, wed = 3, thu = 4, fri = 5, sat = 6, sun = 7;
Console.WriteLine("Введите номер дня недели:  ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == mon | a == tue | a == wed | a == thu | a == fri)
{
    Console.WriteLine("Сегодня будний день.");
}
if (a == sat | a == sun)
{
    Console.WriteLine("Сегодня выходной день.");
}
