//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем - первой и последний элемент массива.
//Парой считаем - второй и предпоследний элемент массива и т.д.
//Результат выводим как новый массив из вычесленых произведений пар.
using System;
using static System.Console;

Clear();




//метод создания массива из строки, метод позволит всю строчку разбить и преобразавать в числовой массив.
int[] GetArrayFromString(string stringArray)
{                                                                                     //StringSplitOptions.RemoveEmptyEntries - удаляет из массива двойные пробелы
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries); //данный оператор разбивает на заданные элементы массив.
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++) //необходимо добавить служебное слово .Length
    {
        result[i] = int.Parse(numS[i]);  //данным действием мы набираем значения в массив result
    }
    return result;
}