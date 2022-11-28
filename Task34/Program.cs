// Задать массив заполненый случайными положительными трехзначными числами
//Показать кол-во четных чисел в массиве
using System;
using static System.Console;

Clear();

WriteLine("Введите размер массива: ");
int enter = int.Parse(ReadLine());        
int[] array = GetArray(enter);        // = GetArray(ReadLine()); работать небудет! 
string G = String.Join(", ", array);

int count = GetCountElements(array);
string I = String.Join(", ", count);
Write($"[{G}], четных элементов --> [{I}]");   //строка нужна только для офрмления ответа в []  




// метод создания массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)    // Важно! не требуется .Length
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

//метод возращает из массива кол-во элементов находящихся в заданом диапозоне 
int GetCountElements(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}