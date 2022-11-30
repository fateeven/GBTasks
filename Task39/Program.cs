// Программа переворачивает одномерный массив
//Последний элемент станет первым, а первый последний и т.д.
//[1, 2, 3, 4, 5] ->[5, 4, 3, 2, 1]
// Переворачиваем 2 методами
using System;
using static System.Console;

Clear();

Write("Введите нужную длинну массива(кол-во чисел): ");
int A = int.Parse(ReadLine());
Write("Введите минимальное значение массива: ");
int B = int.Parse(ReadLine());
Write("Введите Максимальное значение массива: ");
int C = int.Parse(ReadLine());

if (A <= 0 || B > C)
{
    WriteLine("Ошибка ввода, размер массива не может быть < или = 0");
    return;
}

int[] array = GetArray(A, B, C);
string G = String.Join(", ", array);

int[] array2 = ReverseArray(array);
string I = String.Join(", ", array2);

WriteLine($"[{G}] - > [{I}]");

ReverseArray2(array);
string T = String.Join(", ", array);
WriteLine();
WriteLine($"Переворачиваем 1-ый массив вторым методом - > [{T}]");

//метод создания массива
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

//метод возвращает новый развернутый массив
int[] ReverseArray(int[] inArray)
{
    int[] result = new int[inArray.Length];

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[inArray.Length - 1 - i];
    }
    return result;
}


//метод меняет местами элементы в действующем массиве
void ReverseArray2(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}