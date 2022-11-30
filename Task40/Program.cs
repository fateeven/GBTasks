// Программа  принимает 3 значения и проверяет может ли существовать треугольник
//Сумма 2 сторон должна быть больше 3 стороны
using System;
using static System.Console;

Clear();

Write("Введите длину отрезка А: ");
int A = int.Parse(ReadLine());
Write("Введите длину отрезка B: ");
int B = int.Parse(ReadLine());
Write("Введите длину отрезка C: ");
int C = int.Parse(ReadLine());  

if(A+B>C&&A+C>B&&B+C>A)
{
    WriteLine("Может");
}
else
{
    WriteLine("Не может");
}

//--------------------------------------------------

//второй метод записи кода, с методом bool:
Write("Введите стороны треугольника через пробел: ");
string[] numS = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
if (isTriangle(int.Parse(numS[0]),int.Parse(numS[1]), int.Parse(numS[2]))) //в проверке if сразу используем возвращаемое методом значение
{
    WriteLine("Может");
}
else
{
    WriteLine("Не может");
}

// метод bool истина-ложь, проверяет может ли существовать треугольник
bool isTriangle(int a, int b, int c)
{
    return (a+b>c&&a+c>b&&b+c>a);
}
