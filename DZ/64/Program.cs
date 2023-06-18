// Импортируем пространство имен System для использования его классов
using System;

// Импортируем статический класс Console из пространства имен System для вывода информации в консоль
using static System.Console;

string Numbers (int N)
{
    if(N == 1)
    {
        WriteLine(1);
        return "1";
    }
    string s = N.ToString() + " " + Numbers(N-1);
    WriteLine(s); 
    return s;
}

string s = Numbers(6);