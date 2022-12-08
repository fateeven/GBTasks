//В некотором машинном алфавите имеются четыре буквы а, и , с, в
//Покажите слова состоящие из n букв, которые можно построить из букв этого алфавита
using System;
using static System.Console;


Clear();
string chars = "аивс";  //вводим переменную которая формирует наш словарь, и указываем буквы которые будут участвовать в переборе.
int count = 2;          //вводим переменную - кол-во символов которое будем выводить как ответ при переборе

PrintWords(chars, count, "");


//метод который будет рекурсивно перебирать наши буквы c помощью рекурсии
void PrintWords(string alphabet, int length, string prefix)
{
    if (length == 0) Write($"{prefix} ");
    else
        foreach (char c in alphabet) PrintWords(alphabet, length - 1, prefix + c);
}