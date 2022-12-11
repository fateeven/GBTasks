//Программа которая на вход принимает число N,
//на выходе выдает является ли число четным(делится ли оно на 2 без остатка)
using System;
Console.Clear();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

if (N%2==0)
{
    Console.WriteLine($"Число {N} делится на 2 без остатка");
}
else
{
    Console.WriteLine($"Число {N} не делится на 2 без остатка"); 
}
