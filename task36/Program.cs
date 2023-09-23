/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/ 

Console.Clear();

int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] arr = new int [size];
	Random rnd = new Random();
    int i = 0;
	for (i=0; i < arr.Length; i++)
	{
		arr[i]=rnd.Next(min, max+1);
	}
	return arr;
}

void PrintArray(int[] arr)
{
	Console.Write("[");
	for (int i=0; i<arr.Length; i++)
	{
		if (i<arr.Length-1 ) Console.Write ($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
	}
	Console.Write("]");
}

int[] array = CreateArrayRndInt(6,-50,50);
PrintArray(array);

int SumUneven (int[] arr)
{
    int sumUneven=0;
    int i=0;
    while (i<arr.Length)
    {
        if (i % 2 != 0) sumUneven += arr[i];
        i+=1;
    }
    return sumUneven;
}
int sumUneven = SumUneven(array);
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных местах = {sumUneven}");