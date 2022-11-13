using System;
Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int max = A;
if(max<B)
{
    max = B;
}
Console.WriteLine($"max= {max}");