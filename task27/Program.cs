// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit (int number)
{
    int count=Convert.ToString(number).Length;
    int res=0;
    if (number == 0)
    {
        res=1;
    }
    for (int i = 0; i < count; i++)
    {
        res=res+number%10;
        number=number/10;
    }
    return res;
}

int sumDigit = SumDigit (number);
Console.WriteLine("Сумма цифр в числе: " + sumDigit);