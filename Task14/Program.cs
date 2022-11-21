using System;
using static System.Console;
Clear();
Write("Введите число: ");
int N = int.Parse(ReadLine());
if((N % 7 ==0)&&(N % 23 == 0)) 
{
    WriteLine($"{N} -> Да");
}
else
{
    WriteLine($"{N} -> Нет"); 
}