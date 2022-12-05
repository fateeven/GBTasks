// Задайте число N. Напишите программу, которая выведет все натуральные числа
//в промежутке от 1 до N и от N до 1 в обратном порядкею С помощью рекурси.
//также добавлены методы сумирования и умножения чисел.
using System;
using static System.Console;

Clear();
Write("Введите значение N: ");
int n = int.Parse(ReadLine());

Write("Введите значение M: ");
int m = int.Parse(ReadLine());

WriteLine(PrintNumber(m, n));
WriteLine(PrintNumber1(n, m));
WriteLine(SumNumbers(m, n));
WriteLine(MultiplicationNumbers(m, n));


//метод вернет строку состоящую из чисел от 1 до N
string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();   // принудительно приведем число к строке  
    return (start + " " + PrintNumber(start + 1, end));
}

//метод вернет строку состоящую из чисел от N до 1 в обратном порядке
string PrintNumber1(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber1(start - 1, end));
}

//метод вернет сумму чисел от N до 1
int SumNumbers(int start, int end)
{
    if (start == end) return start;
    return end + SumNumbers(start, end - 1);
}

//метод вернет произведение чисел от N до 1
int MultiplicationNumbers(int start, int end)
{
    if (start == end) return start;
    return end * MultiplicationNumbers(start, end - 1);
}