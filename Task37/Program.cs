//Найдите произведение пар чисел в одномерном массиве.
//Парой считаем - первой и последний элемент массива.
//Парой считаем - второй и предпоследний элемент массива и т.д.
//Результат выводим как новый массив из вычесленых произведений пар.
using System;
using static System.Console;

Clear();
Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
int[] outArray = GetResultArray(array);
string G = String.Join(", ", outArray);
WriteLine($"Сформирован массив из произведений пар вводного массива -> [{G}]");


//метод создания массива из строки, метод позволит всю строчку разбить и преобразавать в числовой массив.
int[] GetArrayFromString(string stringArray)
{                                                                                  //StringSplitOptions.RemoveEmptyEntries - удаляет из массива двойные пробелы
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries); //данный оператор разбивает на заданные элементы массив.
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++) //необходимо добавить служебное слово .Length
    {
        result[i] = int.Parse(numS[i]);  //данным действием мы набираем значения в массив result
    }
    return result;
}

// метод создания выходного массива с результатом произведения пар
int[] GetResultArray(int[] inArray)
{
    int size = inArray.Length / 2;          //сначала зададим длину нового массива, согласно условия длина будет/2 либо длина/2+1(нечетный 1 массив)
    if (inArray.Length % 2 == 1)
    {
        size++;                             // добавляем +1 к size в случае если массив нечетный.
    }    

    int[] result = new int[size];           //набираем массив

    for (int i = 0; i < inArray.Length / 2; i++)
    {                                                             // Cогласно условиям нам нужно получить произведение какжой пары,
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i]; // для этого мы с кажом шагом будем отнимать i от длины вводного массива.
    }                                                             // но,  так-как 1-й элемент i=0, а последний = -1 , то не забываем это учесть, 
                                                                  // что делает решение верным с учетом цикличности.
    if (inArray.Length % 2 == 1)                                  //Проверяем теперь на нечетность новый массив и если массив нечетный, то  
    {                                                             //приравниваем центральный элемент к последнему элементу массива. -1 не отнимаем.          
        result[size - 1] = inArray[inArray.Length / 2];           //так-как деление целочисленое и нам автоматом отбросит на еденицу меньше.
    }                                                                                                               
    return result;
}