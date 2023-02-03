// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if (!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

int[] array = GenerateArray(-30, 30, 4);
PrintArray(array);
for (var i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
        {
            Console.Write("Да");
            break;
        }
        else Console.Write("нет");
    }

void PrintArray(int[] array)
{
    string message = string.Join(",", array);
    Console.WriteLine($"[{message}]");
}

// int NumberSeach(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         if (array[i] == a)
//         {
//             Console.WriteLine("Да");
//         }
//         else Console.WriteLine("нет");
//     }
// }

int[] GenerateArray(int min, int max, int length)
{
    Random random = new Random();
    int[] array = new int[length];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }

    return array;
}
