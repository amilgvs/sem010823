// Напишите программу, которая 
// 1. на вход подает число 
// 2. и выдает его квадрат
// Например 4->16, -3->9, -7->49

Console.WriteLine ("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int squere = number * number;
Console.WriteLine ($"Квадрат числа {number} = {squere}");