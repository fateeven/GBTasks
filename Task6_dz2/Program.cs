//Программа принимает на вход три числа, и выдает ответ какое число максимальное
using System;
Console.Clear();
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = int.Parse(Console.ReadLine());
int max = A; // назначаем А максимальным элементом по умолчанию и далее сравниваем

if (max < B)
{
    max=B;
}
if (max < C)
{
    max=C;
}
Console.WriteLine($"Максимальное из введенных чисел:-> {max} ");