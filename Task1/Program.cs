//Программа на вход принимает два числа и проверяет
//является ли первое число квадратом второго
using System;
Console.Clear();

Console.Write("Enter 1st number: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Enter 2nd number: ");
int b = int.Parse(Console.ReadLine());

//Решение с помощью условия if, else if, else  и математического решения нахождения квадрата 
if (a * a == b) Console.WriteLine($"{b} is a square of {a}");
else if (b * b == a) Console.WriteLine($"{a} is a square of {b}");
else Console.WriteLine("There are NO squares!");
