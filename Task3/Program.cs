using System;
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int S = -N;
while (S<=N)
{
    Console.Write($"{S} ");
    S++;
}