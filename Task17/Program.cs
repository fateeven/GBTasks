﻿using System;
using static System.Console;
Clear();

Write("Введите координату x:");
int x = int.Parse(ReadLine());
Write("Введите кординату y:");
int y = int.Parse(ReadLine());
if (x == 0 || y == 0)
    WriteLine("Координата x не должна быть равной 0");
else if ((x > 0) && (y > 0))
    WriteLine("Точка находиться в 1 четверти плоскости координат");
else if ((x < 0) && (y < 0))
    WriteLine("Точка находиться в 3 четверти плоскости координат");
else if ((x > 0) && (y < 0))
    WriteLine("Точка находиться в 4 четверти плоскости координат");
else if ((x < 0) && (y > 0))
    WriteLine("Точка находиться в 2 четверти плоскости координат");