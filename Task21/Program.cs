//Программа, которая принимает на вход координаты двух точек 
//и находит растояние между ними в 3D пространстве.
using System;
using static System.Console;

Clear();
Write("Введите координаты точки A, x1:");
int x1 = int.Parse(ReadLine());
Write("Введите координаты точки A, y1:");
int y1 = int.Parse(ReadLine());
Write("Введите координаты точки A, z1:");
int z1 = int.Parse(ReadLine());
Write("Введите координаты точки B, x1:");
int x2 = int.Parse(ReadLine());
Write("Введите координаты точки B, y2:");
int y2 = int.Parse(ReadLine());
Write("Введите координаты точки B, z2:");
int z2 = int.Parse(ReadLine());

double D = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
WriteLine($"Длина отрезка AB = {D:f2}");