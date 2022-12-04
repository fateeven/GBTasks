// Задайте прямоугольный двумерный массив.Напишите программу которая будет находить
// строку с найменьшей суммой элементов.
using System;
using static System.Console;

Clear();
Write("Введите кол-во строк и столбцов двумерного массива через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите минимальное и максимальное значения двумерного массива через пробел: ");
string[] values = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetATwoDimensionalArray(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(values[0]), int.Parse(values[1]));
PrintATwoDimensionalArrey(array);

WriteLine(); //--------------------

WriteLine($"Строка с наименьшей суммой {GetNumberRow(array)}");




//Метод формирования двумерного массива
int[,] GetATwoDimensionalArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];

    for (int i = 0; i < result.GetLength(0); i++)                  // цикл для rows
    {
        for (int j = 0; j < result.GetLength(1); j++)              // цикл для columns
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); // рандомно запалняем массив с учетом минимального и максимального значения
        }
    }
    return result;
}

//Метод Void печати двумерного массива 
void PrintATwoDimensionalArrey(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]}\t ");                     // \t - это команда по табуляции вывода, можно ставить слева или справа от {} 
        }
        WriteLine();                                        // не забываем пробелs для строк и стобцов           
    }
}

//Метод возвращает номер строки в которой находится минимальная сумма элементов
int GetNumberRow(int[,] inArray)
{
    int row = 0;
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)    //работаем только с первой строкой
    {
        sum += inArray[0, i];
    }

    for (int i = 1; i < inArray.GetLength(0); i++)  //ложные циклы
    {
        int minSum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            minSum += inArray[i, j];
        }
        if (sum > minSum)
        {
            sum = minSum;
            row = i;
        }
    }
    return row;
}