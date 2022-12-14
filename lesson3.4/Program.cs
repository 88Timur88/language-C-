/*
Задача 22: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
int[] array =

5 -> 1, 4, 9, 16, 25. 2 -> 1,4
*/

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

int[] GetTableOfSquares(int num)
{
    int[] arr = new int[num];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = (int)(Math.Pow(i+1, 2));
        }
return arr;
}

int[] squaresTable = GetTableOfSquares(num);

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
PrintArray(squaresTable);