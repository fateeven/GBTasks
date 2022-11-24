using System;
using static System.Console;

Clear();

WriteLine($"[{String.Join(", ", GetBinaryArray(8))}]");



//метод
int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i=0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}