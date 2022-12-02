//Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными числами
using System;
using static System.Console;

Clear();
Write("Введите кол-во строк и столбцов двумерного массива через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите минимальное и максимальное значения двумерного массива через пробел: ");
string[] values = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[,] array = GetATwoDimensionalArray(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(values[0]), int.Parse(values[1]));
PrintATwoDimensionalArrey(array);



//Метод формирования двумерного массива типа double
double[,] GetATwoDimensionalArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] result = new double[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)                  // цикл для rows
    {
        for (int j = 0; j < result.GetLength(1); j++)              // цикл для columns
        {                                                                                          //используем прием для получения дробных чисел
            result[i, j] = ((double)(new Random().Next(minValue * 10, (maxValue + 1) * 10))) / 10; //целые числа * на 10, далее преобразовываем в double и делим 10
        }                                                                                          //таким приемом мы получим числа с первыми десятыми.
    }
    return result;
}

//Метод Void печати двумерного массива типа double
void PrintATwoDimensionalArrey(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t ");                     // \t - это команда по табуляции вывода, можно ставить слева или справа от {} 
        }
        WriteLine();                                          // не забываем пробелs для строк и стобцов           
    }
}