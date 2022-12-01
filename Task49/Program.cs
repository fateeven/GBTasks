//  Задайте двумерный массив. Найдите элементы, у
//  которых оба индекса чётные, и замените эти элементы на их квадраты
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

ChangeATwoDimensionalElements(array);
PrintATwoDimensionalArrey(array);


//Метод формирования двумерного массива
int[,] GetATwoDimensionalArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    
    for (int i = 0; i < result.GetLength(0); i++)                  // цикл для rows
    {
        for (int j = 0; j < result.GetLength(1); j++)              // цикл для columns
        {
            result[i,j] = new Random().Next(minValue, maxValue+1); // рандомно запалняем массив с учетом минимального и максимального значения
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

//метод который будет изменять значения элементов у которых оба индекса чётные!, и заменит эти элементы на их квадраты
void ChangeATwoDimensionalElements(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)       
    {                                                    
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0)                         //выполняем условие
            {
                array[i,j]*= inArray[i,j];                //возводим в квадрат найденые четные элементы
            }
        }
    }
}