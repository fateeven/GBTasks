using System;
Console.Clear();
Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine());


// нужна помощь с вводом значения (-B)² и отображением квадрата в ответе.
if(B<0&&A<0)
{
    Console.WriteLine($"Да {B} является квадратом {A} -> -B²=-(B²)=-(B*B)=-A");
}
if(B<0&&A>0)
{
    Console.WriteLine($"Да ({B}) является квадратом {A} -> (-B)²=(-B)*(-B)=A");
}
// нужна помощь с вводом значения (-B)² и отображением квадрата в ответе.

if(B*B==A)
{
    Console.WriteLine("Да, B является квадратом A");
}

else
{
    Console.WriteLine("Нет, B не является квадратом A");
}


//Важно!!! алгоритм не работает корректно с минусовыми числами, т.е не  видит разницы между -5 и (-5)
//-B²=-(B²)=-(B*B)=-A
//(-B)²=(-B)*(-B)=A
