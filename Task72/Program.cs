//Заданы 2 массива: info и data. 
//В массиве info хранятся двоичные представления нескольких чисел(без разделителя)
//В массиве data хранится информация о кол-ве бит, которые занимают числа из массива info.
//Напишите программу, которая составит массив десятичных представлений чисел массива data
//с учетом информации из массива info.
using System;
using static System.Console;


Clear();
int[] data = new int[] { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = new int[] { 2, 3, 3, 1 };
//в начале нужно проверить ровна ли длина массива data сумме элементов массива info
if (GetSum(info) != data.Length)
{
    Write("Нельзя преобразовать данные массивы");
    return;
}
else
    WriteLine(String.Join(" ", GetResultArray(data, info)));




//метод нахождения суммы элементов в массиве
int GetSum(int[] inArray)
{
    int sum = 0;
    foreach (int item in inArray)
    {
        sum += item;
    }
    return sum;
}

//Метод преобразует два массива к исхожному результирующему массиву
int[] GetResultArray(int[] dataArray, int[] infoArray)
{
    int[] result = new int[infoArray.Length];
    string data = String.Join("", dataArray); //переводим значиние чисел в строку, а далее будем преобразовывать нужные символы в десятичной системе исчесления.
    for (int i = 0; i < infoArray.Length; i++)
    {   //cперва вырежим необходимое количество символов из нашей строки
        string substr = data.Substring(0, infoArray[i]);
        result[i] = Convert.ToInt32(substr, 2); //теперь переводим из 2ичной системы в 10;
        data = data.Remove(0, infoArray[i]);    //из строк удаляем первые символы
    }
    return result;
}
