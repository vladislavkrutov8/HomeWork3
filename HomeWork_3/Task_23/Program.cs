﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num  = Convert.ToInt32(Console.ReadLine());

void PrintСube (int a)
{
    for (int i = 1; i <= a; ++i)
    Console.WriteLine($"{i} \t {i*i*i}");
}
PrintСube (num);