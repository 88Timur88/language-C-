// See https://aka.ms/new-console-template for more information

int n = int.Parse(Console.ReadLine());

if(n == 1)
{
    Console.WriteLine("Понедельник");
}
if(n == 2)
{
    Console.WriteLine("Вторник");
}
if(n == 3)
{
    Console.WriteLine("Среда");
}
if(n == 4)
{
    Console.WriteLine("Четверг");
}
if(n == 5)
{
    Console.WriteLine("Пятница");
}
if(n == 6)
{
    Console.WriteLine("Суббота");
}
if(n == 7)
{
    Console.WriteLine("Воскресенье");
}
if(n < 1 | n > 7)
{
    Console.WriteLine("Неправильно введено число");
}