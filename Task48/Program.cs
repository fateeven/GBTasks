//Задайте двумерный массив размером m×n, 
//Каждый элемент массива находится по формуле A[i,j]=i+j и вывести массив на экран
using System;
using static System.Console;

Clear();
Write("Введите кол-во строк через пробел: ");
string[] m = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите кол-во столбцов через пробел: ");
string[] n = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetATwoDimensionalArray(int.Parse(m[0]), int.Parse(n[0]));
PrintATwoDimensionalArrey(array);


//Метод формирования двумерного массива
int[,] GetATwoDimensionalArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    
    for (int i = 0; i < result.GetLength(0); i++)                  // цикл для rows
    {
        for (int j = 0; j < result.GetLength(1); j++)              // цикл для columns
        {
            result[i,j] = i+j;                                     // меняем формулу набора согласно условиям задачи
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
            Write($"{inArray[i, j]}\t ");                   // \t - это команда по табуляции вывода, можно ставить слева или справа от {} 
        }
        WriteLine();                                        // не забываем пробелs для строк и стобцов           
    }
}