// Задайте две матрицы.Напишите программу которая будет находить произведение двух матриц.
using System;
using static System.Console;

Clear();
Write("Введите кол-во строк и столбцов первой матрицы через пробел: ");
string[] nums1 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите минимальное и максимальное значения первой матрицы через пробел: ");
string[] values1 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array1 = GetATwoDimensionalArray(int.Parse(nums1[0]), int.Parse(nums1[1]), int.Parse(values1[0]), int.Parse(values1[1]));
PrintATwoDimensionalArrey(array1);

WriteLine(); //--------------------

Write("Введите кол-во строк и столбцов второй матрицы через пробел: ");
string[] nums2 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Write("Введите минимальное и максимальное значения второй матриц через пробел: ");
string[] values2 = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,] array2 = GetATwoDimensionalArray(int.Parse(nums2[0]), int.Parse(nums2[1]), int.Parse(values2[0]), int.Parse(values2[1]));
PrintATwoDimensionalArrey(array2);

WriteLine(); //--------------------

if(array1.GetLength(1)!= array2.GetLength(0))
{
    WriteLine("такие матрицы умножать нельзя");
    return;
}
int[,] array3 = GetResultMatrix(array1, array2);

WriteLine("Произведение двух матриц: "); //--------------------
PrintATwoDimensionalArrey(array3);



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

//Метод нахождения произведения двух матриц
int[,] GetResultMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] resultMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)]; // размер итоговой матрицы будет кол-во строк матрицы A и количество столбцов матрицы B.
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return resultMatrix;
}