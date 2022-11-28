//Задать массив размера 123 из случайных чисел  необходимо найти кол-во элементов массива. 
//между значениями 10 и 99
using System;
using static System.Console;

Clear();

int[] array = GetArray(123, 0, 1000);
string G = String.Join(", ", array);  
int counts = GetCountElements(array, 10, 99);
WriteLine($"[{G}]");
WriteLine($"Найдено {counts} элемент(ов), в диопозоне значений [от 10 до 99].");


// метод создания массива
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)    // Важно! не требуется .Length
    {
        result[i] = new Random().Next(min, max+1);
    }
    return result;
}

//метод возращает из массива кол-во элементов находящихся в заданом диапозоне 
int GetCountElements(int[] inArray, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item>=leftRange&&item<=rigthRange)
        {
            count++;
        }
    }
    return count;
}