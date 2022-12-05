//Сформируйте трехмерный массив из неповторяющихся двузначных чисел
//Программа выводит массив, добавля индексы каждого элемента
using System;
using static System.Console;

Clear();
Write("Введите размер трехмерной матрицы через пробел: ");
string[] size = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
Write("Введите порог минимального и максимального значения трехмерной матрицы через пробел: ");
string[] values = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[,,] array = GetThreeDimensionalArray(int.Parse(size[0]), int.Parse(size[1]), int.Parse(size[2]), 
int.Parse(values[0]), int.Parse(values[1]));

PrintThreeDimensionalArray(array);



//Метод ищет элемент в трехмерном массиве, нам необходима инфрмация только о том есть значение или нет
//нужен для того что бы двухзначные значения элементов не повторялись.
bool FindElement(int[,,] inArray, int elementValue)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j <  inArray.GetLength(1); j++)
        {
            for (int k = 0; k <  inArray.GetLength(2); k++)
            {
                if(inArray[i,j,k]==elementValue) return true;
            }
        }
    }
    return false;
}

//метод формирования рандомного трехмерного массива
int[,,] GetThreeDimensionalArray(int m, int n, int k, int minValue, int maxValue)
{
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int t =0;
            while (t< result.GetLength(2))
            {
                int randomValue = new Random().Next(minValue, maxValue);
                if(FindElement(result, randomValue)) continue;
                result[i,j,t] = randomValue;
                t++;
            }
        }
    }
    return result;
}

//метод вывода трехмерного массива, с доволением индексов  каждого элемента
void PrintThreeDimensionalArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i,j,k]} ({i},{j},{k})  ");
            }
            WriteLine();
        }
        WriteLine();
    }
}