// Задайте двумерный массив из целых чисел
//Найти среднее арифметическое элементов в каждом столбце
//дополнительно введена строка для поиска среднего арифметического в каждой строке
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

string G = String.Join("; ", GetSumColumns(array));
WriteLine($"Среднее арифмметическое каждого столбца = [{G}]");

WriteLine(); //--------------------

string I = String.Join("; ", GetSumRows(array));
WriteLine($"Среднее арифмметическое каждой строки = [{I}]");



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

//метод вычисляет среднее арифметическое каждого столбца double
double[] GetSumColumns(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(1)]; //длина нового масива result будет ровна кол-ву столбцов входящего массива
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        double sum = 0;             //вводим переменную - сумму значенией в столбце
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
            sum += inArray[j,i];      //Важно, для верного результат поставить первым индексом - j, а вторым i
        }
        result[i] = sum / inArray.GetLength(0);
    }
    return result;
}


//метод вычисляет среднее арифметическое каждой строки double
double[] GetSumRows(int[,] inArray)
{
    double[] result = new double[inArray.GetLength(0)]; //длина нового масива result будет ровна кол-ву столбцов входящего массива
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        double sum = 0;             //вводим переменную - сумму значенией в столбце
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i,j];      //Важно, для верного результат поставить первым индексом - j, а вторым i
        }
        result[i] = sum / inArray.GetLength(1);
    }
    return result;
}
