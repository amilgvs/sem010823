/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/ 

Console.Clear();

double[] CreateArrayRndInt(int size)
{
    double[] arr = new double[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.NextDouble()*100;
    }
    return arr;
}

void PrintArray(double[] arr)
{
	Console.Write("[");
	for (int i = 0; i < arr.Length; i++)
	{
		if (i<arr.Length-1 ) Console.Write ($"{arr[i] :F2}, ");
        else Console.Write($"{arr[i] :F2}");
	}
	Console.Write("]");
}

double[] arr = CreateArrayRndInt(6);
PrintArray(arr);

double Max (double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if (arr[i] > max) max = arr[i];
    }
    return max;
}

double Min (double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if (arr[i] < min) min = arr[i];
    }
    return min;
}

double max = Max (arr);
double min = Min (arr);

Console.WriteLine($" => {max:F2} - {min:F2} = {max-min :F2}");

