//Частотный словарь значений элементов двумерного массива
//Показывает сколько раз встречается каждое значение в заданном массиве
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

int[] rowArray = GetRowArray(array);
SortArray(rowArray);
WriteLine(String.Join(" ", rowArray));

WriteLine(); //--------------------

PrintData(rowArray);

WriteLine(); //--------------------




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

//метод возвращает одномерный массив с кол-вом элиментов двумерного массива
int[] GetRowArray(int[,] inArray)
{
    int[] rowArray = new int[inArray.GetLength(0) * inArray.GetLength(1)]; // сумма всех элементов ровна кол-во столбцов* кол-во строк
    int index = 0;                                                        // запишет в себя все элементы
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            rowArray[index] = inArray[i, j];
            index++;                          // таикм способом мы перепишем все элементы двумерного массива
        }
    }
    return rowArray;
}

//Пузырьковый метод сортировки одномерного массива
void SortArray(int[] rowArray)
{
    for (int i = 0; i < rowArray.Length; i++)
    {
        for (int j = i + 1; j < rowArray.Length; j++)
        {
            if (rowArray[i] > rowArray[j])
            {
                int k = rowArray[i];
                rowArray[i] = rowArray[j];
                rowArray[j] = k;
            }
        }
    }
}

//метод который будет выводит необходимый нам результат
void PrintData(int[] inArray)
{
    int element = inArray[0]; // ввели переменную равную первому элементу в полученом одномерном массиве.
    int count = 1;           // будет подсчитывать, сколько повторяется каждый элемент в массиве. count = 1, потому что element уже имеет значение [0];
    for (int i = 1; i < inArray.Length; i++)
    {
        if (inArray[i] != element)
        {
            WriteLine($"{element} встречается {count} раз.");
            element = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
}