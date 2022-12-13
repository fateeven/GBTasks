// Задать массив заполненый случайными числами
// Показать сумму элементов стоящих на нечетных позициях(нечетный индекс) в массиве
using System;
using static System.Console;

Clear();

Write("Введите нужную длинну массива(кол-во чисел): ");
int A = int.Parse(ReadLine());
Write("Введите минимальное значение массива: ");
int B = int.Parse(ReadLine());
Write("Введите Максимальное значение массива: ");
int C = int.Parse(ReadLine());

if (A <= 0 || B > C)
{
    WriteLine("Ошибка ввода, размер массива не может быть < или = 0");
    return;
}

int[] array = GetArray(A, B, C);
string G = String.Join(", ", array);
WriteLine($"[{G}]");
int sum = GetSummNumbersOddndex(array);
string I = String.Join(", ", sum);
WriteLine($"[Сумма значений нечетных индексов массива = {sum}]");



// метод создания массива
int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)    // Важно! не требуется .Length
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}

//метод возращает сумму элементов нечетных индексов массива
int GetSummNumbersOddndex(int[] inArray)
{
    int result = 0; //сумма нечетных индексов

    for (int i = 0; i < inArray.Length; i++)
    {               //Если поменяем на i%2==0 - получим сумму всех четных индексов в массиве                                                            
        if (i % 2 == 1)  //Если поменяем на inArray[i]%2==1 - получим сумму всех нечетных чисел в массиве
        {           //Если поменяем на inArray[i]%2==0 - получим сумму всех четных чисел в массиве
            result += inArray[i];  // Если поменяет на result+=i - получим кол-во нечетных индексов в массиве и т.д.
        }
    }

    return result;  //сумма нечетных индексов
}