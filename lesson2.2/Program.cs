// Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа.
// 456 -> 46 782 -> 72 918 -> 98

Random random = new Random();
int number = random.Next(99,1000);
Console.WriteLine(number);

int firstNumber = number / 100;
int lastNumber = number % 10;

int result = firstNumber*10 + lastNumber;

Console.WriteLine(result);