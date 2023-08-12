// Напиши программу, которая 
// на вход принимает два числа и 
// проверяет, является ли 
// первое число квадратом второго
// а=25 б=5 -> да, а=2 б=10 -> нет

Console.WriteLine ("Введите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
{
    if(a==b*b)
    {
        Console.WriteLine ("да");
    }
    else 
    {
        Console.WriteLine("нет");
    }
}