using System;
Console.Clear();
Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());

if(B*B==A)
{
    Console.WriteLine("Да, B является квадратом A");
}

else
{
    Console.WriteLine("Нет, B не является квадратом A");
}

