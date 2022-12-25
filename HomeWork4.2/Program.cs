// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

int result = 0;
int sum;
while(a != 0)
{
    sum = a % 10;
    a = a / 10;
    result = result + sum;    
}
Console.WriteLine(result);