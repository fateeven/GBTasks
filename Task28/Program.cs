//Программа, принимает на вход число N 
//и выдает произведение чисел от 1 до N. т.е. факториал N
using System;
using static System.Console;
Clear();
//основной код программы
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int summa = GetFactorialNumbers(N);


if (N == 0)
{
    WriteLine($"Факториал {N}! = 1");
}
else if (N < 0)
{
    WriteLine($"Введите число => 0");
}
else
{
    WriteLine($"Факториал {N}! = {summa}");
}


//метод:
int GetFactorialNumbers(int number)
{
    int i = 1;
    int factorial = 1; // переменная которая будет возвращаться
    while (i <= number) // Важно! если поставить(number>i) - будет ошибка в расчетах на 1 множитель.
    {                                  //если (number=>) - будет ошибка кода.
        factorial *= i;
        i++;
    }
    return factorial;  //для того чтобы наша функция что-то вернула, пишем команду return и переменную factorial, которую будем возвращать

}
