﻿/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.WriteLine ("Задайте значение N");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

Row(N);

void Row(int num)
{
    if (num == 0) return;    
    Console.Write($"{num} ");
    Row (num - 1) ;
}