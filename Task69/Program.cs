// Программа на вход принимает два числа А и B, и возводит число А в целую степень B
//с помощью рекурсии
using System;
using static System.Console;

Clear();
Write("Введите значение A: ");
int A = int.Parse(ReadLine());
Write("Введите значение B: ");
int B = int.Parse(ReadLine());
WriteLine($"{A} в степени {B} = {Pow(A,B)};");

//метод возведения в степень с помощью рекусии
int Pow(int number, int degree)
{
    if(degree==0) return 1;
    if(degree==1) return number;
    return(number*Pow(number, degree-1));
}