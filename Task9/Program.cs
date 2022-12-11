//Программа, которая выводит случайное число из отрезка[10,99]
//и показывает наибольшую цифру случайного двухзначного числа
using System;
using static System.Console;              //данная команда позволяет далее в коде не прописывать Console
Clear();

int number = new Random().Next(10, 100); // Второе значение берем на 1 больше(учитывыем нумерацию индекса с 0)
int a1 = number / 10;
int a2 = number % 10;
if (a1 > a2)
{
    WriteLine($"{number}->{a1}");
}
else
{
    WriteLine($"{number}->{a2}");
}

