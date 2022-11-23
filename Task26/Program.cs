using System;
using static System.Console;
Clear();
//основной код программы
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int summa = GetCountNumbers(N);
WriteLine($"{N} -> Кол-во цифр: {summa}");



int GetCountNumbers(int number)
{
    int count = 0; // переменная которая будет возвращаться
    while(number>0)
    {
        number/=10;   // number = number / 10;
        count++;     // count = count + 1;
    }
    return count;  //для того чтобы наша функция что-то вернула, пишем команду return и переменную count, которую будем возвращать
}