// Написать программу, которая принимает на вход число
// и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите целое число:");
bool isParsed = int.TryParse(Console.ReadLine(), out int b);
if(!isParsed)
{
    Console.WriteLine($"Введённое значениt не соответствует требованиям!!!");
    return;
}
if(b == 0)
{
    Console.WriteLine("Ввели неправильно число");
    return;
}

if(b % 7==0 && b % 23==0) Console.WriteLine($"Введенное значение {b} кратно одновременно 7 и 23");
else Console.WriteLine($"Введенное значение {b} не кратно 7 или 23");
