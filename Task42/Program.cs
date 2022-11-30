// Программа преобразовывает десятичные числа в двоичные
// 2 решения мтематическое и используя функции библиотек С#
using System;
using static System.Console;

Clear();
Write("Введите 10-чное число которое хотите преобразовать:  ");
int X = int.Parse(ReadLine());
Write("Введите число, в какую систему систему исчисления хотите перевести:  ");
int Y = int.Parse(ReadLine());

//метод использования стандартных функции библиотек С#
string S1 = Convert.ToString(X, Y); // у метода ToString есть 2-ва параметра(1, 2) 1- это числоб 2- это формат в которой переводим
WriteLine($"{X} -> {S1}");

//---------------------------------------------------
//Второй Метод

string S2 = GetToNums(X, Y);
string I = String.Join(", ", S2);

WriteLine($"{X} -> {I}");

//Второй, математический метод, без переворота
string GetToNums(int number, int sys) //1-числоб 2 - формат в который переводим
{
    string result = "";               //эта переменная строка будет собирать наше число, а строка это тоже массив с индексами
    string chars = "0123456789abcdef";  //эта строк будет содержать все нужные нам системы изчисления, от 0 до 16, при желании можно расширить.
    while (number > 0)                  //с помощью цикла будем дилить введенное число
    {
        int del = number / sys;         //вводим переменную которая будет собирать  результать деления числа на формат sys.
        int ost = number - del * sys;   //остаток собирает в себя разность, пример ost = 45 - 22*2 = 1. Остаток мы будем складывать в массив нового числа
        result += chars[ost].ToString(); // то что получилось в разности ost будем искать в символах chars и вставлять этот символ в наш результат+ значение нашей строк result. ToString нужен на случай если в разности будет кодировк(ABCDEF)
        number /= sys;                  //не забываем уменьшать наше число numberб так как оно меняется с каждым циклом нахождения остататка
    }
    return ReverseAnsver(result);                    //возвращаем уже перевернутый результат, с помоощью метода ReverseAnsver
}

//метод возврощает новый, перевернутый массив из строки
string ReverseAnsver(string oldString)
{
    string reversString = string.Empty;           //набор нового массива с пустой строки

    for (int i = oldString.Length - 1; i >= 0; i--)  //i=0 меняем на i= длина массива который ъотим перевернуть, oldString.Length-1; так как индекс считает с 0. 
    {                                             //Далее с каждым циклом отнимаем -1 от длины, пока длина не станет равной 0
        reversString += oldString[i];              //почередно, в пустую строку, складываем индексы, начинаяя с последнего индекса oldString.Length-1
    }
    return reversString;
}


//--------------------------------------------------------
//третий метод

int GetIntFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}

string GetTenToTwo(int a)
{
    string res = "";
    while (a > 0)
    {
        res += (a % 2).ToString();          // выбираем число в какую систему переводим, пока не работает с кодами abcdef и тд
        a /= 2;                             //// выбираем число в какую систему переводим, пока не работает с кодами abcdef и тд
    }
    return ReverseArrayFramework(res);
}

string ReverseArrayFramework(string res)
{
    char[] arr = res.ToCharArray();
    Array.Reverse(arr);
    return new String(arr);
}

int message1 = GetIntFromConsole("Enter A = ");
WriteLine(GetTenToTwo(message1));