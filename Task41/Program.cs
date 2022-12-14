// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
using System;
using static System.Console;

Clear();

Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
string G = String.Join(" ", array);

int sum = GetCountPositivNumbers(array);
string I = String.Join(", ", sum);

Write($"[{G}] --> [{I}]");

WriteLine();//---------------------------------- похожий метод foreach

int sum2 = GetCountPositivNumbers2(array);
string H = String.Join(", ", sum);
WriteLine($"[{G}] --> [{H}] foreach");

//метод создания массива из строки, метод позволит всю строчку разбить и преобразавать в числовой массив.
int[] GetArrayFromString(string stringArray)
{                                                                                  //StringSplitOptions.RemoveEmptyEntries - удаляет из массива двойные пробелы
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries); //данный оператор разбивает на заданные элементы массив.
    int[] result = new int[numS.Length];    //необходимо добавить служебное слово .Length
    for (int i = 0; i < result.Length; i++) //необходимо добавить служебное слово .Length
    {
        result[i] = Convert.ToInt32(numS[i]);  //можно заменить на int.Parse(numS[i]); данным действием мы набираем значения в массив result
    }
    return result;
}
//----------------------------------
//метод возращает сумму положительных чисел в массиве
int GetCountPositivNumbers(int[] inArray)
{
    int result = 0; //количество положительных значений

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > 0)
        {
            result++;
        }
    }
    return result;  //кол-во положительных чисел
}

//Можно посчитать количество положительных чисел в массиве через метод foreach
int GetCountPositivNumbers2(int[] inArray)
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item > 0) return count++;
    }
    return count;
}