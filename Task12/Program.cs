using System;
using static System.Console;
Clear();
Write("Введите число A: ");
int A = int.Parse(ReadLine());
Write("Введите число B: ");
int B = int.Parse(ReadLine());
if (A % B==0)
{
    WriteLine($"{A},{B} -> кратно");
}
else
{
    WriteLine($"{A},{B} -> не кратно, остаток {A % B}");
}
   