// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число ==>");
int a = int.Parse(Console.ReadLine());

if(a > 99 && a < 1000)
{
    int b = a % 100;
    int secondNumber = b / 10;
    Console.WriteLine(secondNumber);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}