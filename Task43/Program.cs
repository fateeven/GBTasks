// Программа, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
using System;
using static System.Console;

Clear();

Write("Введите b1, k1, b2 и k2 через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] point = GetPoint(double.Parse(nums[0]), double.Parse(nums[1]), double.Parse(nums[2]), double.Parse(nums[3])); // принимаем координаты точек в double
Write($" - > [{String.Join(" ; ", point)}]"); 


//метод возвращает координаты точек (double)
double[] GetPoint(double b1, double k1, double b2, double k2)
{
    double[] point = new double[2];
    point[0] = (b2-b1)/(k1-k2); //расчитаем координату X
    point[1] = point[0]*k1+b1;  //расчитаем координату Y (используем уровнение прямой из условия)

    return point;
}

