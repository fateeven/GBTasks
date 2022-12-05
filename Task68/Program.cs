﻿//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
using System;
using static System.Console;

Clear();
Write("Введите значение M: ");
int M = int.Parse(ReadLine());
Write("Введите значение N: ");
int N = int.Parse(ReadLine());


WriteLine($"Функция Аккермана = {Akkerman(M, N)}");


//Метод Аккермана
int Akkerman(int m, int n)
{
    if(m==0) return n+1;
    if(n==0) return Akkerman(m-1,1);
    return Akkerman(m-1, Akkerman(m,n-1));
}