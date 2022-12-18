/*Напишите программу, которая принимает на вход пятизначное число и проверяет,
 является ли оно палиндромом. Задание должно быть выполнено в методе.
  В методе не должно быть вывода в консоль. Не использовать String!
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Введите пятизначное число: ");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

if(number < 10000)
{
    Console.WriteLine($"Введенное число {number} не соответствует требуемым кретериям");
    return;
}
if(number > 99999)
{
    Console.WriteLine($"Введенное число {number} не соответствует требуемым кретериям");
    return;
}
else
{
    int a = number / 10000;
    int res2 = number / 1000;
    int res3 = number / 10;
    int b = res2 % 10;
    int c = res3 % 10;
    int d = number % 10;

    if(a == d && b == c)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}