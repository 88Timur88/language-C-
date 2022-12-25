// Напишите программу, которая принимает на вход два числа (A и B) и 
// метод который возводит число A в натуральную степень B. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать Math.Pow()

Console.WriteLine("Введите число А: ");
bool isParsedA = int.TryParse(Console.ReadLine(), out int a);
if(!isParsedA)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}
Console.WriteLine("Введите число B: ");
bool isParsedB = int.TryParse(Console.ReadLine(), out int b);
if(!isParsedB)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

int result = GetSumOfNumbersInInterval(a, b);

Console.WriteLine(result);

int GetSumOfNumbersInInterval(int a, int b)
{
    int sum = a;
    int i = 1;

    while(i < b)
    {
        sum = sum * a;
     
        i++;
    }

    return sum;
}