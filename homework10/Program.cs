// Урок 10. Рекурсия продолжение
// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех
// чисел на группы, так чтобы в одной группе все числа были взаимно просты (все
// числа в группе друг на друга не делятся)? Найдите M при заданном N и получите
// одно из разбиений на группы N ≤ 10²⁰.
// 25 мин
// Например, для N = 50, M получается 6
// - Группа 1: 1
// - Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// - Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// - Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// - Группа 5: 7 16 24 36 40
// - Группа 6: 5 32 48

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
                if ((m + 1) % m > 0 && (m + 2) % m > 0 && (m + 6) % m > 0)
                {
                    grup = grup + 1;
                    Console.Write($"Группа {grup}: ");
                    Console.Write(m + " ");
                    Console.WriteLine();
                    return GroupN(n, m + 1);
                }
                if ((m + 4) % m > 0 && (m + 3) % m > 0)

                    if ((m + 4) % m > 0 && (m + 8) % m > 0)
                    {
                        grup = grup + 2;
                        Console.Write($"Группа {grup}: ");
                        Console.Write(m + " ");
                        Console.WriteLine();
                        return GroupN(n, m + 1);
                    }
                if ((m + 7) % m > 0 && (m + 5) % m > 0)
                {
                    grup = grup + 3;
                    Console.Write($"Группа {grup}:  ");
                    Console.Write(m + " ");
                    Console.WriteLine();
                    return GroupN(n, m + 1);
                }
            }
            Console.WriteLine();
            return GroupN(n, m);
        }
    }
    if (n == m)
    {
        return 1;
    }
    else return 0;
}
GroupN(13, 0);

