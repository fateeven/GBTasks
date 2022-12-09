//Программа на вход принимает число и выдает его квадрат
using System;
using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
//Математическое решение
int sqr = number * number;
WriteLine($"Квадрат числа равен: {sqr}");
//Решение с помощью встроенной функции Math.Pow(x, y) х- входяще число, y - степень которая требуется, записывается нужным числом
int sqr1 = Convert.ToInt32(Math.Pow(number, 2));
WriteLine($"Квадрат числа, найденый 2-ым способом, равен: {sqr1}");