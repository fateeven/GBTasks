using System;
using static System.Console;
Clear();

Write("Введите число четверти плоскости координат, от 1 до 4: ");
int x = int.Parse(ReadLine());
if(x>4)
{
    WriteLine("Неверное число четверти, введите значение от 1 до 4");
}
if(x<1)
{
    WriteLine("Неверное число четверти, введите значение от 1 до 4");
}
if(x==1)
{
    WriteLine("x>, y>0");
}
if(x==2)
{
    WriteLine("x<, y>0");
}
if(x==3)
{
    WriteLine("x<, y<0");
}
if(x==4)
{
    WriteLine("x>, y<0");
}

// 2-e решение
switch(x)
{
    case 1:
    {
        WriteLine("x>, y>0");
        break;
    }
    case 2:
    {
        WriteLine("x<, y>0");
        break;
    }
    case 3:
    {
        WriteLine("x<, y<0");
        break;
    }
    case 4:
    {
        WriteLine("x>, y<0");
        break;
    }
    default:
    {
        WriteLine("Неверное число четверти, введите значение от 1 до 4");
        break;
    }


}