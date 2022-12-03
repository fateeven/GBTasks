//Задайте двумерный массив. Напишите программу которая упорядочит по убыванию
//элементы каждой строки двумерного массива
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

SortATwoDimensionalArray(array);
PrintATwoDimensionalArrey(array);




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

//Пузырьковый метод, сортировки элементов строк двумерного массива по убыванию
void SortATwoDimensionalArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    { 
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = j+1; k < inArray.GetLength(1); k++)
            {
                if (inArray[i,k] > inArray[i,j])            //если поменяем знак > на < сортировка строк будет проведена по возрастанию
                {
                    int temp = inArray[i,j];
                    inArray[i,j] = inArray[i,k];
                    inArray[i,k] = temp;
                }
            }
        }
    }
}