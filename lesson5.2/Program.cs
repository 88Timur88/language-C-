// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
//и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] c = GenerateArray(-9, 9, 4);
PrintArray(c);
Console.WriteLine();
int[] b = ModifiedArray(c.array);
PrintArray(b);


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

int[] ModifiedArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1; 
    }
    return array;
}