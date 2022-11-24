using System;
using static System.Console;
Clear();
//основной код программы
Write("Введите число N: ");
int N = int.Parse(ReadLine());
int summa1 = GetCountNumbers(N);
int summa2 = GetCountNumbers(-N); //добавление данной переменной с минусом N, позволяет считать сумму цифр или кол-во цифр в минусовых числах

if(N==0)
{
    WriteLine($"Так как '{N}' является цифрой, то кол-во цифр: 1");
}
else if(N<0)
{
    WriteLine($"{N} -> Кол-во цифр: {summa2}");
}
else
{
    WriteLine($"{N} -> Кол-во цифр: {summa1}");
}


//метод:
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