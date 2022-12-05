//  Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
using System;
using static System.Console;

Clear();
Write("Введите значение N: ");
int n = int.Parse(ReadLine());
Write("Введите значение M: ");
int m = int.Parse(ReadLine());

if(m>n)
{
    WriteLine(StringPrintNumbers(n, m));
}
else
{
    WriteLine(StringPrintNumbers(m, n));
}

//метод вернет строку состоящую из чисел от N до 1 в обратном порядке
string StringPrintNumbers(int start, int end)
{
    if (start == end) return end.ToString();
    return end + " " + StringPrintNumbers(start, end - 1);
}
