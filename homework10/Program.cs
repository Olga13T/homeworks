// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
// Console.WriteLine("Введите число N: ");
// int n = Console.ReadLine();




int GroupN(int n, int m)
{
    if (n <= 0) return 0;

    if (n > 0)
    {
        if (m < n)
        {
            int grup = 1;
            m = m + 1;
            if (m == 1)
                Console.Write($"Группа {grup}:  {m} ");
            if (m > 2)
            {
                if (m % 4 > 0 && m % 9 > 0)
                {
                    grup = grup + 1;
                    Console.Write($"Группа {grup}: ");
                    Console.Write(m + " ");
                    Console.WriteLine();
                    return GroupN(n, m + 1);
                }
                //  if ( (m+ % 9 > 0)
                // {
                //     grup = grup + 2;
                //     Console.Write($"Группа {grup}: ");
                //     Console.Write(m + " ");
                //     Console.WriteLine();
                //     return GroupN(n, m + 1);
                // }
                if ( m % 7 > 0 && m % 5 > 0)
                {
                    grup = grup + 3;
                    Console.Write($"Группа {grup}:  ");
                    Console.Write(m + " ");
                    Console.WriteLine();
                    return GroupN(n, m + 1);
                }

                else
                {
                    grup = grup + 4;
                    Console.Write($"Группа {grup}:   ");
                    Console.Write(m + " ");
                    Console.WriteLine();
                    return GroupN(n, m + 1);
                }
            }
            Console.WriteLine();
            return GroupN(n, m);

        }
        // Console.Write($"Group -******** {m} - ");
    }
    if (n == m)
    {
        // Console.Write($"Группа _f  - {m} ");
        return m;
    }
    else return 0;
}
GroupN(31, 0);


