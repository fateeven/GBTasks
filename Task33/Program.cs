// Программа, позволяет пользователю найте искомое число в массиве
using System;
using static System.Console;

Clear();
Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
string G = String.Join(" ", array);  

Write("Введите элемент: ");
int Element = int.Parse(ReadLine());

if (FindElementInArray(array, Element))
{
    WriteLine($"Элемент {Element} найден в массиве {G}");
}
else
{
    WriteLine($"Элемента {Element} нет в массиве {G}");
}


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

//метод bool, метод поиска нужного нам числа в массиве.
bool FindElementInArray(int[] inArray, int inElement)
{
    foreach (int item in inArray)
    {
        if (item == inElement) return true;
    }
    return false; // если после проверки всех элементов массива искомый элемент не будет найдет вернется false.
}