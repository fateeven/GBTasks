using System;
using static System.Console;
Clear();
//основной код программы
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int summa1 = GetCountSummNumbers(N);
int summa2 = GetCountSummNumbers(-N); //добавление данной переменной с минусом N, позволяет считать сумму цифр или кол-во цифр в минусовых числах

if (N < 0)
{
    WriteLine($"Сумма цифр в числе {N} = {summa2}");
}
else
{
    WriteLine($"{N} Сумма цифр в числе {N} = {summa1}");
}


//метод:
int GetCountSummNumbers(int number)
{
    int summ = 0; // переменная которая будет возвращаться
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }

    return summ;  //для того чтобы наша функция что-то вернула, пишем команду return и переменную count, которую будем возвращать
}