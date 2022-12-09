//Программа принимает на вход два числа и выдает,
//какое из чисел максимальное, или сообщает о их равенстве.
using System;
Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

if (A < B)
{
    Console.WriteLine($"max = {B}");
}
else if (A > B)
{
    Console.WriteLine($"max = {A}");
}
else
{
    Console.WriteLine($"{A} = {B}");
}
