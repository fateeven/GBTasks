using System;
using static System.Console;
Clear();
Write("Введите A: ");
int A = int.Parse(ReadLine());
Console.Write("Введите B: ");
int B = int.Parse(ReadLine());

if(B*B==A)  //используем математический метож
{
    WriteLine($" {A} является квадратом {B}");
}
else
{
    if(Math.Pow(A, 2)==B) //используем функциию, заменяет(A*A==B)
    {
        WriteLine($" {B} является квадратом {A}");
    }
    else
    {
        WriteLine("Не является");
    }
    
}

//Дополнительная задача!
//16.1
//Вычислить сумму ряда с указанной точностью (e=0,001)
//1+1/2+1/3+1/4...1/бесконечность
//Если последняя точность, последнего действия меньше чем e, то завершаем цикл с помощью break;

double summ = 0;
double lastOperation = 0;
const double eps = 0.001; //обяъвляем переменную эпсилон
int divider =1;

do  //тоже самое что while, но сперва выполняеться тело метода, а после while
{
    lastOperation = (double)1 / divider;     // присвоили еденице тип данных double, так как вычесляем вещественные числа
    System.Console.WriteLine(lastOperation); // double можно еще написать как 1.0 Пример: 1.0 / 2 = 0.5
    summ+=lastOperation;
    divider++;                 
}while (lastOperation > eps);
System.Console.WriteLine($"answer = {summ}");