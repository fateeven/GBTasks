//Программа на вход принимает положительное число N, на выходе
//покажет все четные числа от 1 до N
using System;
Console.Clear();

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
//первое решение
int i = 1;                         //создаем переменную равную 1
while (i <= N)                     //запускаем цикл +1, пока число N меньше или равно 1
{
    if (i % 2 == 0)                //действует условие, делим каждоем последующее число на 2 и сравниваем остатк c 0
    {                              //если остатка нет, т.е равен 0, то печатаем переменную, если остаток больше 0 -не печатаем
        Console.Write($"{i}, ");
    }
    i++;                           //важно вынести i++ за тело условия if, что бы счетчик работал корректно
}
Console.WriteLine(); //---------------
//второе решение
int K = 2;                         //создаем переменную сразу равную 2
while (K <= N)                     //запускаем цикл +2, пока число N меньше или равно 2
{
    Console.Write($"{K}, ");       //таким цикл будет состоят всегда только из четных чисел.
    K += 2;
}
