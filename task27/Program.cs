// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit (int number)
{
    int count=Convert.ToString(number).Length;
    int temp=0;
    int res=0;
    for (int i = 0; i < count; i++)
    {
        temp=number-number%10;
        res=res+(number-temp);
        number=number/10;
    }
    return res;
}

int sumDigit = SumDigit (number);
Console.WriteLine("Сумма цифр в числе: " + sumDigit);