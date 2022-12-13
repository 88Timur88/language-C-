// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

Console.WriteLine("ВВедите первое чиcло, не равное 0 ==>");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число, не равное 0 ==>");
int b = int.Parse(Console.ReadLine());

int quarter = a * a;
if(quarter == 0)
{
    Console.WriteLine("Ноль нельзя вводить!!!");
    return;
}

if(b == quarter) Console.WriteLine("yes");
else Console.WriteLine("no");
