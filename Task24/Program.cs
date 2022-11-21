using System;
using static System.Console;
Clear();
//основной код программы
Write("Введите числа A: ");
int A = int.Parse(ReadLine());
int summa = GetSumNumbers(A);
WriteLine($"Сумма всех чисел от 1 до {A} -> {summa}, ");



// хоошим тоном является если метод пишется внизу
int GetSumNumbers(int number)
{
    int sum = 0; // переменная которая будет возвращаться
    for (int i = 1; i <= number; i++)
    {
        sum+=i;  // sum+=i тоже самое что и  sum=sum+i
    }
    return sum;  //для того чтобы наша функция что-то вернула, пишем команду return и переменную sum, которую будем возвращать
}
