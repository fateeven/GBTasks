//Программа которая получает на вход число А 
//и выдает сумму чисел от 1 до А
using System;
using static System.Console;

Clear();
//Тело программы
int a = ReadFromConsole("Enter A: ");  //вызываем 1-ый метод
int summ = GetSumNumbers(a);           //вызываем 2-ой метод
WriteLine($"The sum of the numbers from {a} = {summ}"); 


// метод возращает сумму целых чисел ряда от 1 до А
int GetSumNumbers(int number)
{
    int sum = 0; // переменная которая будет возвращаться
    for (int i = 1; i <= number; i++)
    {
        sum+=i;  // sum+=i тоже самое что и  sum=sum+i
    }
    return sum;  //для того чтобы наша функция что-то вернула, пишем команду return и переменную sum, которую будем возвращать
}

//метод чтения из консоли 
int ReadFromConsole(string message) //название метода
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}


