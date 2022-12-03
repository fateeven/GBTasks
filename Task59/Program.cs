//Из двумерного массива цулых чисел удалить строку и столбуц,
//на пересечении которых расположен первый наименьший элемент.
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

string minIndex = String.Join("; ", GetMinIndex(array));
WriteLine($"Индекс минимального элемента в массиве -> [{minIndex}]");

WriteLine(); //--------------------

PrintATwoDimensionalArrey(DeleteResultRowsAndColumns(array,GetMinIndex(array)));



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


//метод ищет индекс минимального значения
int[] GetMinIndex(int[,] inArray)
{
    int[] result = new int[] {0,0};
    int min = inArray[0,0];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if(min>inArray[i,j])
            {
                min = inArray[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

//метод принимает двумерный массив и удаляет строку и столбец на котором находиться минимальный элемент
int[,] DeleteResultRowsAndColumns(int[,] inArray, int[] index)
{
    int[,] result = new int[inArray.GetLength(0)-1, inArray.GetLength(1)-1];
    int row = 0;
    int column= 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if(i==index[0]) continue;     //ищем строку которую нам нужно удалить, после переходим к следующему шагу.
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           if(j==index[1]) continue;  //ищем колонку которую нам нужно удалить, после переходим к следующему шагу.
           result[row, column] = inArray[i, j]; //если условие не выполняется, тогда в результирующий массив записываем значение переменной входного массива
           column++;
        }
        row++;       //при обходе строк увеличиваем значение на еденицу, когда мы закончили одну строку
        column = 0;  //переменную со значением столбцов обнуляем.
    }
    return result;  //в конце вернем наш массив
}
