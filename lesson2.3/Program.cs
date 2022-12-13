// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число -->");
int firstNumber = int.Parse(Console.ReadLine());
if(firstNumber == 0)
{
    Console.WriteLine("На ноль делить нельзя! Поменяйте число");
    Console.WriteLine("Введите заново первое число -->");
    int firstNumber2 = int.Parse(Console.ReadLine());
    if(firstNumber2 == 0) Console.WriteLine("Ошибка");
    else firstNumber = firstNumber2;
}
else
{Console.WriteLine("Введите второе число -->");
    int secondNumber = int.Parse(Console.ReadLine());

    int rest = secondNumber % firstNumber;

    if(rest == 0) Console.WriteLine("Поздравляем! Второе число кратно первому");
    else
    {
        Console.Write("Второе чило не кратно первому. Остатнок от деления равен =");
        Console.WriteLine(rest);
    };
}
