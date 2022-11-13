using System;
Console.Clear();
Console.Write("Введите трехзначное число: ");
int N = int.Parse(Console.ReadLine());
int sqr = N%10;
Console.WriteLine($"Последняя цифра: {sqr}");
