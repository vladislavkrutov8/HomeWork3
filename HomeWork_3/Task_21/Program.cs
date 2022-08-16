﻿// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координаты первой точки x: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты первой точки y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты первой точки z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки x: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты второй точки z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double cord = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));

Console.WriteLine(Math.Round(cord,2));