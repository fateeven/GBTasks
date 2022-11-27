// Написать программу замены положительных элементов массива на отрицательные и наооборот
using System;
using static System.Console;

Clear();
int[] array = GetArray(8, -10, 10);
string G = String.Join(", ", array);                     
InverseArray(array);
string I = String.Join(", ", array);
Write($"[{G}] --> [{I}]");                //строка нужна только для оформления ответа в []  


//метод инверсии чисел  в массиве, без возврата значения
void InverseArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++) // добавили к переменной array свойство Length которое вернет нам кол-во элиментов в массиве
    {
        inArray[i] *= -1; //значение каждого индекса в массиве умножается на -1.
    }
}

//метод формирования массива
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}