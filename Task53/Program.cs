//Задайте двумерный массив. Напишите метод который поменяет местами
//первую и последнюю строку массива, выведет на экран новый массив
//и еще раз проведет смену первой и последней строки, выведет 3-й массив
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

ChangeFirstAndLastRows(array);          // // первая смена строк и вывод массива

WriteLine(); //--------------------

ChangeFirstAndLastRows1(array);        // вторая смена строк и вывод уже измененного массива, приводит массив к изначальному виду


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

//метод меняет строки местами, первую с последней. 
void ChangeFirstAndLastRows(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++) //идем по кол-ву столбцов и забираем значения строк
    {
        int result = inArray[0, i];
        inArray[0, i] = inArray[inArray.GetLength(0) - 1, i];
        inArray[inArray.GetLength(0) - 1, i] = result;
    }
    PrintATwoDimensionalArrey(inArray);
}

//Второй метод добавлен как пример, по сути тот же самый метод ChangeFirstAndLastRows, только записан иначе (x,y) = (y,x)
void ChangeFirstAndLastRows1(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(1); i++) //идем по кол-ву столбцов и забираем значения
    {
        (inArray[0, i], inArray[inArray.GetLength(0) - 1, i]) = (inArray[inArray.GetLength(0) - 1, i], inArray[0, i]);
    }
    PrintATwoDimensionalArrey(inArray);
}

