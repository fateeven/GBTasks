using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
int sqr = number * number;
WriteLine($"Квадрат числа равен: {sqr}");

int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
WriteLine($"Квадрат числа, найденый 2-ым способом, равен: {sqr1}");