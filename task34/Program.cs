/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int[] array = CreateArrayRndInt(5,100,999);
PrintArray(array);

int CountEven (int[] arr)
{
    int countEven=0;
    int i=0;
    while (i<arr.Length)
    {
        if (arr[i] % 2 == 0) countEven++;
        i+=1;
    }
    return countEven;
}
int countEven = CountEven(array);
Console.WriteLine();
Console.WriteLine($"Число четных = {countEven}");