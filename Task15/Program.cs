using System;
Console.Clear();
Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine($"{1} -> нет");
}
if (number == 2)
{
    Console.WriteLine($"{2} -> нет");
}
if (number == 3)
{
    Console.WriteLine($"{3} -> нет");
}
if (number == 4)
{
    Console.WriteLine($"{4} -> нет");
}
if (number == 5)
{
    Console.WriteLine($"{5} -> нет");
}
if (number == 6)
{
    Console.WriteLine($"{6} -> да");
}
if (number == 7)
{
    Console.WriteLine($"{7} -> Да");
}
if (number>7||number<1)
{
    Console.WriteLine("Ошибка ввода");
}