﻿// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти (от 1 до 4");
int a = int.Parse(Console.ReadLine());

if(a > 0 && a < 5) 
{
    if(a == 1) Console.WriteLine("x > 0, y > 0");
    if(a == 2) Console.WriteLine("x < 0, y > 0");
    if(a == 3) Console.WriteLine("x < 0, y < 0");
    if(a == 4) Console.WriteLine("x > 0, y < 0");
}
