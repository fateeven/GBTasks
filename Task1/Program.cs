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
    return;
}
if(B<0&&A>0)
{
    Console.WriteLine($"Да ({B}) является квадратом {A} -> (-B)²=(-B)*(-B)=A");
}
// нужна помощь с вводом значения (-B)² и отображением квадрата в ответе.

