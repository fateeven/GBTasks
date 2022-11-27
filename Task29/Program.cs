//Данная программа выводит на экран массив  из случайных целых чисел;
//Позволяет пользователю задать длину массива;
//Поозволяет пользователю задать минимальное и максимальное значение массива;
//Позволяет пользователю отсортировать рандомный массива по убыванию или возрастанию.

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
    Console.WriteLine("Ошибка ввода, размер массива не может быть < или = 0");
    return;                                       // * узнать как оптимально вернутся к предложению ввода А:, вместо return?
}

int[] sort = GetRandomArray(A, B, C);
string G = String.Join(", ", sort);
WriteLine($"[{G}]");
WriteLine("Хотите отсортировать данный массив?");
WriteLine("Ведите: 0-нет, 1-по возрастанию, 2-по убыванию: ");
int p = int.Parse(ReadLine());

if (p > 2 || p <= 0)
{
    WriteLine($"[{G}]");
    return;
}
else if (p == 1)
{
    SortIncreasing(sort);
    PrintArray(sort); 
}
else
{
    SortDescending(sort);
    PrintArray(sort);
}

//метод создания рандома
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

//метод вывода массива(из лекции)
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        //int M = array[i];                                  //  * Узнать кк поставить всю длину массива в одной [   ]?
        //string N = String.Join(", ", M);                   //  * в коментариях слева - попытк вывести  всю длину массива в одной [   ]
        //Write($"[{N}]");
        //WriteLine($"[{String.Join(", ", N)}]");
        Console.Write($" {array[i]} ");                      //  * не смог вывести ответ всю длину массива в одной [   ]
    }
    Console.WriteLine();
}
//метод сортировки по возрастанию(из лекции)
void SortIncreasing(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // -1 нужна что бы выровнить общее кол-во элементов массива Length
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)    //прибавляем i + 1 -необходимо для последовательной сортировки j
        {
            if (array[j] < array[minPosition])   //если поменять знак меньше на больше, то маcсив выстроится от максимального к минимальному значению
                minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
//метод сортировки по убыванию(из лекции)
void SortDescending(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++) // -1 нужна что бы выровнить общее кол-во элементов массива Length
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)    //прибавляем i + 1 -необходимо для последовательной сортировки j
        {
            if (array[j] > array[minPosition]) //если поменять знак меньше на больше, то маcсив выстроится от максимального к минимальному значению
                minPosition = j; 
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
