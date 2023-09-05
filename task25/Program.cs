// Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите два числа: ");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());

int Exponentiation (int A , int B)
{
    int res=1;
    int i=1;
    while (i<=B)
    {
        res=res*A;
        i++;
    } 
    return res;
}    

int result = Exponentiation (A , B);
Console.WriteLine ($"{A} в степени {B} -> {result}");
