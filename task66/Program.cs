// /*Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30*/

Console.WriteLine("Задайте значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте значение N");
int N = Convert.ToInt32(Console.ReadLine());

int Count(int M, int N)
{
    if (M == N) return M;
    else if (M < N) return M + Count (M+1,N);
	else return M + Count(M-1,N);
}
Console.WriteLine($"Сумма чисел от М до N = {Count(M , N)}");

