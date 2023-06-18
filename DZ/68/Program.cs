// Импортируем пространство имен System для использования его классов
using System;

// Импортируем статический класс Console из пространства имен System для вывода информации в консоль
using static System.Console;

    static int A(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return A(m - 1, 1);
        }
        else
        {
            return A(m - 1, A(m, n - 1));
        }
    }

int s = A(2,3);
WriteLine(s);