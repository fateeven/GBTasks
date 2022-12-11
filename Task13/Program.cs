//Программа которая выводит третью цифру заданного числа
//или сообщает что третьей цифры нет.
using System;
using static System.Console;

Clear();
//Первое решение математическое(неоптимальное)
Write("Введите число: ");
int x = int.Parse(ReadLine());
if (x < 100)
{
    WriteLine("Третьей цифры нет");
}

if ((x > 99) && (x < 1000))
{
    int sqr = x % 10;
    WriteLine($"Третья цифра числа {x} -> {sqr}");
}

if ((x > 1000) && (x < 10000))
{
    int sqr0 = (x / 10) % 10;
    WriteLine($"Третья цифра числа {x} -> {sqr0}");
}

if ((x > 10000) && (x < 100000))
{
    int sqr1 = (x / 100) % 10;
    WriteLine($"Третья цифра числа {x} -> {sqr1}");
}

if ((x > 100000) && (x < 1000000))
{
    int sqr2 = (x / 1000) % 10;
    WriteLine($"Третья цифра числа {x} -> {sqr2}");
}

if ((x > 1000000) && (x < 10000000))
{
    int sqr3 = (x / 10000) % 10;
    WriteLine($"Третья цифра числа {x} -> {sqr3}");
}

if (x > 10000000)
{
    WriteLine("Программа не поддерживает числа больше чем 8-ми значные");
}


//второе решение с использованием индекса строки
Write("Введите число: ");
string number = ReadLine();
int Length = 3;
if (number.Length < Length)
{
    Write("Третьей цифры нет");
}
else
{
    Write($"Третья цифра числа {number} -> {number[2].ToString()}");
}


WriteLine(); //---------------

//Третье решение математическое
Write("Введите число: ");
int N = int.Parse(ReadLine());

if (N < 100)
{
    System.Console.Write("Третьей цифры нет");
    return 0;
}

int num = N;

for (int i = 10; num > 999;)
{
    num /= i;
}

System.Console.Write($"Третья цифра числа {N} -> {num % 10}");
return 0;
