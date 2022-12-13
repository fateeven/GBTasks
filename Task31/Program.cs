﻿// Написать программу которая задает массив размером 12 чисел, из случайных целых чисел [от -9 до 9]
// Подсчитывает сумму положительных и отрицательных элементов в массиве.
using System;
using static System.Console;

Clear();
int[] array = GetArray(12, -9, 9); // Вызываем метод и прописываем требуемые условия, записываем в переменную.
int positiveSum = 0; //Создаем переменную для записи суммы положительных чисел.
int negativeSum = 0; //Создаем переменную для записи суммы отрицательных чисел.

foreach (int item in array)       //еще один способ(оператор) перебора массива, но в нутри него нельзя изменять элементы массива.
{                                 //после in пишем массив который хотим перебрать(опрасить), в нашем случае это array.
    if (item > 0)                   //item это переменная которая будет поочереди менять элемент массива, вместе с следующим шагом цикла
    {
        positiveSum += item;        //таким образом положительные элементы, с каждым шагом будут суммироваться в positiveSum
    }
    else
    {                             //отрицательные элементы и 0, с каждым шагом будут суммироваться в negativeSum
        negativeSum += item;
    }
}
//далее выводим на печать ответ
WriteLine(String.Join(", ", array));
WriteLine($"Сумма положительных элементов в массиве = {positiveSum}");
WriteLine($"Сумма отрицательных элементов в массиве = {negativeSum}");

//метод создания массива
int[] GetArray(int size, int min, int max) // будем вводить длину массива, минимальное и максимальное число
{
    int[] result = new int[size]; //создаем переменную которую будем возвращать
    for (int i = 0; i < size; i++) // с помощью цикла заполним массив элементами в указанном нами диапозоне
    {
        result[i] = new Random().Next(min, max + 1); // сразу учитываем max+1 что бы захватить максимальный элемент,
    }                                              // в нашем случаем max элемент = 9.(наше пороговое значение)
    return result;                 //возращаем результат, после того как наш массив наберется.
}
