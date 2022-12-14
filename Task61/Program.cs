//Показать треугольник поскаля
//Сделать вывод в виде равнобедренного треугольника
using System;
using static System.Console;

Clear();
Write("Введите количество строк треугольника паскаля: ");
int rows = int.Parse(ReadLine());
PrintTriangle(rows);


//метод создания факториала
int Factorial(int n)
{
    int f = 1;
    for (int i = 1; i <= n; i++)
    {
        f*=i;
    }
    return f;
}

//метод вывода треугольника
void PrintTriangle(int n)   //n- кол-во строк в треугольнике
{
    for (int i = 0; i < n; i++)
    {
        for(int c=0; c<=(n-i); c++)
        {
            Write("  ");
        }
        for(int c=0; c<=i; c++)
        {
            Write("   ");
            Write(Factorial(i)/(Factorial(c)*Factorial(i-c)));
        }
        WriteLine();
    }
}
