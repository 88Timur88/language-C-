﻿// Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 2 -> " -2, -1, 0, 1, 2"
int a = int.Parse(Console.ReadLine());
int b;
int c;
if (a > 0)
{
    b = -a;
    c = a;
}
else
{
    b = a;
    c =-a;
}

while(b < c)
{
    Console.WriteLine(b);
    b +=1;
}