// Напишите программу, которая будет создовать копию заданного массива с помощью поэлементного копрования.
using System;
using static System.Console;

Clear();
Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
string G = String.Join(" ", array); 


int[] Copy = CopyArray(array);
string I = String.Join(" ", Copy);

Write($"[{G}] --> [{I}]");

int[] array2 = array;                  // можно просто присвоить, но лучше пользоватся поэлементным копированием
string H = String.Join(" ", array2);   

WriteLine($"  [{G}] --> [{H}]");      


//метод поэлиментного копирования
int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = inArray[i];
    }
    return result;


}

//метод создания массива из строки, метод позволит всю строчку разбить и преобразавать в числовой массив.
int[] GetArrayFromString(string stringArray)
{                                                                                     //StringSplitOptions.RemoveEmptyEntries - удаляет из массива двойные пробелы
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries); //данный оператор разбивает на заданные элементы массив.
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)     //необходимо добавить служебное слово .Length
    {
        result[i] = Convert.ToInt32(numS[i]);  //можно заменить на int.Parse(numS[i]); данным действием мы набираем значения в массив result
    }
    return result;
}
