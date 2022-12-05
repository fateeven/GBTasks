// Программа принимает на вход число и возвращает сумму его цифр
//456 -> 15
//12 -> 3
using System;
using static System.Console;

Clear();
Write("Введите значение N: ");
int n = int.Parse(ReadLine());
WriteLine($"Cумма цифр числа = {Sum(n)}");

//Метод возвращает сумму цифр числа
int Sum(int number)
{
    if(number==0) return 0;  //return 0 позволит завершить нашу рекусию
    return(number%10+Sum(number/10));
}
