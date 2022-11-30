// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
using System;
using static System.Console;

Clear();

Write("Введите n: ");
int n = int.Parse(ReadLine());
Printnumber(0, 1, n);




//метод печати фибоначи
void Printnumber(int a1, int a2, int size)
{
    Write($"{a1} {a2} ");
    for (int i = 0; i < size - 2; i++) //так как 2 первых значения мы уже вывели, от size отнимаем 2.
    {
        Write($"{a1 + a2} ");          //с помощью строки с суммой двух первых чисел мы строим массив

        int temp = a1 + a2;
        a1 = a2;                     // а меняем значения переменных, таким образом продвигаем их вперед
        a2 = temp;
    }
}


WriteLine();//-----------------------------------------
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

//метод печати числа фибоначи со строкой, важна последовательность
int GetIntFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}
int message = GetIntFromConsole("Enter N = ");

int number1 = 0;
int number2 = 1;
int summ = 0;
string result = "0 1";                          

for (int i = 0; i < message - 2; i++)           //можно сделать i=1 тогда от messsage отниаем -1, а не -2 как в первом варианте
{
    summ = number1 + number2;
    result += " " + summ.ToString();           //ToString(); нужен так как первое зночение в печате у нас строка result, выделено в формуле " "
    number1 = number2;
    number2 = summ;
}

WriteLine(result);