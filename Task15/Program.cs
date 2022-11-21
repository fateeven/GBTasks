using System;
Console.Clear();
Console.Write("Введите число дня недели: ");
int number = int.Parse(Console.ReadLine());
if (number>7||number<1)
{
    Console.WriteLine("Ошибка ввода");
    return;
}


if (number > 5 )
{
    Console.WriteLine($" - > Да");
}
else
{
    Console.WriteLine($" -> нет");
}
