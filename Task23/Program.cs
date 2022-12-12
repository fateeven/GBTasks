//Прогамма, принимает на вход число N и на выходе
//выдает кубы ряда чисел от 1 до N
using System;
using static System.Console;

Clear();
Write("Введите число N: ");
int N = int.Parse(ReadLine());

for (int i = 1; i <= N; i++)
{
    Write($"{Math.Pow(i, 3)}, ");
}