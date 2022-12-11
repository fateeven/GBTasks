//Программа, которая принимает на ввод два числа и выводит
//является ли второе число кратным первому. (делится без остатка)
//Если нет, то программа выводит остаток от деления
using System;
using static System.Console;
Clear();

Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
if (A % B == 0)
{
    WriteLine($"{A},{B} -> кратно");
}
else
{
    WriteLine($"{A},{B} -> не кратно, остаток {A % B}");
}
