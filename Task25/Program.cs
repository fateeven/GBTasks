using System;
using static System.Console;
Clear();
Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
int Pow = GetPowNumbers(A, B);

if (A < 0 || B < 0)
    WriteLine("Введите значения A и B => 0");
else
    WriteLine($"{A} в степени {B} = {Pow}");

//метод to the power
int GetPowNumbers(int x, int y)
{
    if (y == 0)
    {
        return 1;
    }
    int result = x;
    for (int i = 2; i <= y; i++) // Важно! i=2, так как любое х - уже является первой степенью!
    {                        // Важно! Если присвоить i=0 или i=1, будет неверный результат, так произойдет лишнее умножение
        result*=x;
    }
    return result;
}