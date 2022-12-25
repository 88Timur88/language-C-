// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreatArray()
{
Console.Write("Введите количество элементов массива:\t");

int elements = int.Parse(Console.ReadLine());

int[] array = new int[elements];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\n Введите элемент массива под индексом {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
    
}
Console.WriteLine("[{0}]", string.Join(",", array));
return array;
}
int[] resalt = CreatArray();
//Console.WriteLine($"Примайте массив {resalt}:\t");