// Импортируем пространство имен System для использования его классов
using System;

// Импортируем статический класс Console из пространства имен System для вывода информации в консоль
using static System.Console;

int Summ (int N)
{
    if(N == 0)
    {
        return 0;
    }
    return Summ(N-1) + N;
}

int s = Summ(15);
WriteLine(s);