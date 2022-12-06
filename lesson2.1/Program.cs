
// Напишите программу, которая выводит случайное число
// из отрезка [10,99] и показывает наибольшую цифру числа.

Random random = new Random();
int number = random.Next(9,100);
Console.WriteLine(number);

int firstNumber = number / 10;
int lastNumber = number % 10;

if(firstNumber > lastNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(lastNumber);
}
