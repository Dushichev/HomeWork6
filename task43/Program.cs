﻿/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


Console.WriteLine("введиту x1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("введиту y1");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("введиту x2");
double k2 = int.Parse(Console.ReadLine());
Console.WriteLine("введиту y2");
double b2 = int.Parse(Console.ReadLine());

if (k1 == k2 && b1 == b2)
{
    Console.Write("прямые совпадают");
}

else if (k1 == k2) Console.Write("прямые параллельны");


else

{
    double x = (b2 - b1) / (k1 - k2);
    double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine("x=" + x + "   y=" + y);
}

