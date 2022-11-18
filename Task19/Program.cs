using System;
using static System.Console;
Clear();
Write("Введите пятизначное число: ");
int N = int.Parse(ReadLine());
if((N>9999)&&(N<100000))
{
    int x = N/10000;
    int y = N%10;
    int z = (N/1000)%10;
    int f = (N%100)/10;
    int u = (N/100)%10;

    if((x==y)&&(z==f))
    {
        Write($"{N} -> Да, является палиндромом");
        Write($" -> {x}={y}, {u}={u}, {z}={f}");
    }
    else
    {
        Write($"{N} -> Нет, не является палиндромом");
    }
}
else
{
    Write("Ошибка ввода");
}