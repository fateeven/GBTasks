//Программа на вход принимает позиции элемента в двумерном масиве и возвращает
//значение этого элемента или же указаниеб что такого элемент нет.
//(программа поиска нужного нам значения в двухмерном массиве)
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

Write("Введите искомое значениe: ");
int N = int.Parse(ReadLine());

if (GetCountElementValue(array, N)>0)
{
    WriteLine($"Элемент со значением {N} найден {GetCountElementValue(array, N)} раз!");

}
else
{
    WriteLine($"Элемента со значением {N} в данном масиве нет!");
}


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

//метод показывает количество нужных чисел
int GetCountElementValue(int[,] inArray, int elementValue )
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item == elementValue)
        {
            count++;
        }
    }
    return count;
}