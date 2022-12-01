//  Задайте двумерный массив. Найдите сумму элементов, 
//  находящихся на главной диагонали (0,0)(1.1)(2.2) и тд.
using System;
using static System.Console;

Clear();
Write("Введите кол-во строк и столбцов двумерного массива через пробел: ");
string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите минимальное и максимальное значения двумерного массива через пробел: ");
string[] values = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetATwoDimensionalArray(int.Parse(nums[0]), int.Parse(nums[1]), int.Parse(values[0]), int.Parse(values[1]));
PrintATwoDimensionalArrey(array);

WriteLine();  // -------------- разделитель вывода
WriteLine($"-> cумма элементов главной диагнали = {GetSumDiagonalElements(array)}");



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

//метод находит сумму значений эллементов главной диагонали массива 
int GetSumDiagonalElements(int[,] inArray)
{
    int sum = 0;                           // необходимо найти минимальное значение между строкой и столбцов что бы невыходила ошибка при запуске расчетов
    int length = inArray.GetLength(0);     // для этого вводим переменную length и присываеваем ей длину строки массива(кол-во элементов строк)
    if (length > inArray.GetLength(1))     // если длина строки будет больше кол-ва столбцов, то
    {
        length = inArray.GetLength(1);     // длина элементов строки будет ровна кол-ву столбцов тем самым мы избежим ошибку расчетов.
    }

    for (int i = 0; i < length; i++)       // далее идем только по строке
    {
        sum += inArray[i, i];
        Write($"{inArray[i, i]} ");
    }
    return sum;
}
