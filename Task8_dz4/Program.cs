using System;
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int S = 0;
while(i<N)
{
    if(i%2==0)
    {
        S = i;
        Console.Write($"{S}, ");
    }

    i++;
}
