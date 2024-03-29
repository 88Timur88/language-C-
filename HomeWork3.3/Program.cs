﻿/*  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

int InputInt()
{
    Console.WriteLine("ВВедите целое число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum)
    {
        return num;
    }
    else
    {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}
int num = InputInt();

int[] GetCubeTable(int num)
{
    int[] arr = new int[num];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = (int)(Math.Pow(i+1, 3));
        }
return arr;
}

int[] CubeTable = GetCubeTable(num);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
PrintArray(CubeTable);