﻿//Программа, которая на входе принимает число N
//на выходе выдает квадраты чисел от 1 до N
using System;
using static System.Console;

Clear();
Write("Введите число N: ");
int N = int.Parse(ReadLine());

for (int i = 1; i <= N; i++)
{
    Write($"{i * i}, ");
}

//второй вариант решения
// Write("Введите число N: ");
// int N = int.Parse(ReadLine());
// int i = 1;
// while (i <= N)
// {
//     double L = Math.Pow(i, 2);
//     Write($"{L}, ");
//     i++;
// }

Console.WriteLine();  // - роль разделителя задач

// Дополнительная задача
// В один из жарких летних дней Петя и его друг Вася решили купить арбуз. 
// Они выбрали самый большой и самый спелый, на их взгляд. После недолгой процедуры взвешивания весы показали w килограмм. Поспешно прибежав домой, изнемогая от жажды, ребята начали делить приобретенную ягоду, однако перед ними встала нелегкая задача. Петя и Вася являются большими поклонниками четных чисел, поэтому хотят поделить арбуз так, чтобы доля каждого весила именно четное число килограмм, при этом не обязательно, чтобы доли были равными по величине. Ребята очень сильно устали и хотят скорее приступить к трапезе, поэтому Вы должны подсказать им, удастся ли поделить арбуз, учитывая их пожелание. 
// Разумеется, каждому должен достаться кусок положительного веса. 
// Сколько таких вариаций может быть(вывести каждую вариацию на экран)
// Входные данные
// В первой и единственной строке входных данных записано целое число w (1 ≤ w ≤ 100) — вес купленного ребятами арбуза


Console.Write("Введите вес арбуза: ");
int summ = int.Parse(Console.ReadLine());
int summ1 = summ - 1;
if (summ < 1 || summ > 100)
{
    Console.WriteLine($"Таких арбузов не бывает");
    return;
}
else if (summ % 2 == 0)
{
    for (int i = 2; i < summ; i += 2)
    {
        Console.WriteLine($"Доли Пети = {i} , тогда Доли Васи = {summ - i}");
    }
}
else
{
    for (int i = 2; i < summ1; i += 2)
    {
        Console.WriteLine($"Доли Пети = {i} , тогда Доли Васи = {summ1 - i}");
    }
    Console.WriteLine("Остаток 1");
}

//Еще один вариант про арбузы(не работает с нечетными значениями)

WriteLine("Введите массу арбуза, который купили парниши: ");
double weith = Convert.ToDouble(ReadLine());

if (weith % 2 != 0)
{
    WriteLine("не повезло не фартануло, ребятки");
}
else //четное
{
    for (int i = 2; i < weith; i += 2)
    {
        double a = weith - i;
        WriteLine(i.ToString() + " " + a.ToString());
    }
}


// Дополнительная задача 2
// Задать N и вывести # до N елочкой 
// пример
// N = 3;
//   # 
//  ###
// N = 5
//   # 
//  ###
// #####
// N = 7
//    # 
//   ###
//  #####
// #######
// Двумерный цикл 
// Если у нас не должно быть # , то пишем пробел

Console.Write("Введите N: ");
int x = int.Parse(Console.ReadLine());
int centr = x / 2 + 1;
int right = centr + 1;
int Left = centr - 1;

if (x > 0)
{
    for (int i = 1; i <= centr; i++)
    {
        for (int j = 0; j <= x; j++)
        {
            if (Left < j && right > j)
                Write("#");
            else
                Write(" ");
        }
        Left--;
        right++;
        WriteLine();
    }
}
else
{
    WriteLine("Введите число > 0 ");
}





