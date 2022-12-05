// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
using System;
using static System.Console;

Clear();
Write("Введите значение N: ");
int n = int.Parse(ReadLine());
Write("Введите значение M: ");
int m = int.Parse(ReadLine());
// WriteLine(SumNumbers1(n, m));

if(m>n)
{
    WriteLine($"Cумма элементов от числа {n} до {m} = {SumNumbers1(n, m)}");
}
else
{
    WriteLine($"Cумма элементов от числа {m} до {n} = {SumNumbers1(m, n)}");
}


//1метод вернет сумму чисел 
int SumNumbers1(int start, int end)
{
    if (start == end) return start;
    return end + SumNumbers1(start, end - 1);
}

//2-й метод вернет сумму чисел 
int SumNumbers2(int start, int end)
{
    if (start == end) return start;
    return start + SumNumbers2(start+1, end);
}