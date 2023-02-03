// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1 [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = GenerateArray(0, 999, 123);
PrintArray(array);
int count = 0;
for (var i = 0; i < array.Length; i++)
{
    if (array[i] > 9 && array[i] < 100) count = count +1;
}
Console.WriteLine(count);
void PrintArray(int[] array)
{
    string message = string.Join(",", array);
    Console.WriteLine($"[{message}]");
}

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

// int SeachNumbers(int[] array)
// {
//     for (var i = 0; i < array.Length; i++)
//     {
//         int count = 0;
//         if (array[i] > 9 && array[i] < 10)
//         {
//             count += count;
//         }
//         else count++;
//     }
