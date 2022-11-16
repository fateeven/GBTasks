using System;
using static System.Console;
Clear();
Write("Введите A: ");
int A = int.Parse(ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(ReadLine());

if(B*B==A)  //используем математический метож
{
    WriteLine($" {A} является квадратом {B}");
}
else
{
    if(Math.Pow(A, 2)==B) //используем функциию, заменяет(A*A==B)
    {
        WriteLine($" {B} является квадратом {A}");
    }
    else
    {
        WriteLine("Не являеться");
    }
    
}