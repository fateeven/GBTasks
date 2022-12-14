//Программа на вход принимает два числа и выдает первые N чисел, для которых
//каждое следующее число равно сумме предыдущих
using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int a1 = int.Parse(ReadLine());
Write("Введите второе число: ");
int a2 = int.Parse(ReadLine());
Write("Введите длину ряда: ");
int size = int.Parse(ReadLine());
Write($"{a1} {a2} ");
WriteLine(PrintNumber(a1,a2,size-2));



//метод возращения массива
string PrintNumber(int start, int end, int length)
{
    if(length==0) return "";
    return (start+end+ "  " +PrintNumber(end, start+end, length-1));
}
