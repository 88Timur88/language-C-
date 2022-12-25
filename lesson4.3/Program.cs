/* Напишите программу, которая выводит массив из 8 элементов,
 заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

/*Random rnd = new Random();

bool isParsed = int.TryParse(Console.WriteLine(), out int n);

if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}*/

int [] array = new int [8];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 2);
}

void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
}
PrintArray(array);






















/*int [] UserArray = ArrayFilling();
Console.WriteLine(UserArray);

int [] ArrayFilling()
{
    int [] arr = new int [n];
    for(int i = 0; i < arr.Length; i++)
    {
        arr [i] = rnd.Next(0, 2);
    }
    return arr;
}

void PrintArray (int [] array)
{
    for(int i = 0; i < array.Length; i++);
}*/