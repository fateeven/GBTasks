//Задать массив вещественных чисел
//Найти разницу между максимальным и минимальным элементом массива
using System;
using static System.Console;

Clear();

int A = GetintFromConsole("Введите нужную длинну массива(кол-во чисел): = ");
int B = GetintFromConsole("Введите минимальный парог для массива: = ");
int C = GetintFromConsole("Введите максимальный парог для массива: = ");
double[] Arr = GetDoubleArrayFromString(A, B, C);
PrintArray(Arr);
double Res1 = FindMin(C, Arr);
double Res2 = FindMax(B, Arr);
WriteLine();
PrintMaxMinusMin(Res2,Res1);





// метод вывода сообщения и внесения данных
int GetintFromConsole(string message)
{
    Write(message);
    return int.Parse(ReadLine());
}


// метод cоздания массива вещественных чисел
double[] GetDoubleArrayFromString(int inArray, int Min, int Max)
{
    double[] result = new double[inArray];

    for (int i = 0; i < inArray; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (Max - Min) + Min, 2); // пояснения
    }
    return result;
}

//метод вывода
void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        if (i == inArray.Length - 1)
        {
            Write($"{inArray[i]} ");
        }
        else
        {
            Write($"{inArray[i]}, ");
        }
    }
}

//метод поиска минимального значения
double FindMin(double Max, double[] Array)
{
    double min = Max;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
        {
            min = Array[i];
        }
    }
    return min;
}

//метод поиска максимального значения 
double FindMax(double Min, double[] Array)
{
    double max = Min;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            max = Array[i];
        }
    }
    return max;
}

// метод вывода результата
void PrintMaxMinusMin(double a, double b)
{
    double Minus = a - b;
    Write($"Разница между значениями элементов Max {a} и Min {b} = {Minus:f3}");
}




//Задать массив целых чисел
//Найти разницу между максимальным и минимальным элементом массива

WriteLine();


Write("Введите массив через пробел: ");
int[] array = GetArrayFromString(ReadLine());
int outArray = GetResultMaxMinusMin(array);
string G = String.Join(", ", outArray);
WriteLine($"Разница между максимальным и минимальным элементом массива = {G}");



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

//метод возвращает разницы между минимальным и максимальным значением массива
int GetResultMaxMinusMin(int[] inArray)
{
    int min = inArray[0];
    int max = inArray[0];

    foreach (int item in inArray)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }

    int result = max-min;
    return result;
}