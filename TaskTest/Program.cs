
// У нас есть кеш - N $ , мы хотим сохранить его от инфляции, кладем в банк и получаем раз в год M % , 
// через сколько лет у нас получится купить квартиру за K $ , при том , 
// что цена квартиры также растет на Q % если этот процент больше или равен N , 
// то вывести в консоль безысходность 


Console.WriteLine("Enter N - cash ");
double N = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter M % - cash increase %");
double M = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter K - cost ");
double K = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter Q - cost increase %");
double Q = Convert.ToDouble(Console.ReadLine());
int i = 0;
if (Q < M)
{
    while (N <= K)
    {
        N = N + (N / (double)100 * M);
        K = K + (K / (double)100 * Q);
        i++;
    }
    Console.WriteLine($"Жди {i} лет ");
}
else
{
    Console.WriteLine($"Квартиру не получишь");
}

