using System;
using static System.Console;

Clear();
Write("Введите нужную длинну массива(кол-во чисел): ");
int A = int.Parse(ReadLine());
Write("Введите минимальное значение массива: ");
int B = int.Parse(ReadLine());
Write("Введите максимальное значение массива: ");
int C = int.Parse(ReadLine());

WriteLine($"[{String.Join(", ", GetRandomArray(A, B, C))}]");



//метод создания рандом
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}
