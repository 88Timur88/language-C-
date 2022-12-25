/* Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4->24 5->120 */
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

/*void Test()
{
    int [] numbers = new int [] {4, 5};

    int [] sum2 = new int [] {24, 120};

    for(var i = 0; i < numbers.Length; i++)
    {
        double sum1 = GetSumNumbers(numbers[i]);

        if(sum1 != sum2[i])
        {
            Console.WriteLine($"Ожидали {sum2[i]}, а получили {sum1}");
        }
        else
        {
            Console.WriteLine($"Ожидаемый результат {sum2[i]} равен {sum1}");
        }

    }
}*/

double a = GetProductOfNumbers(number);

Console.WriteLine($"Произведение чисел от 1 до {number} равно {a}");

double GetProductOfNumbers(int number)
{
    double sum = 1;
    for(var i = 1; i <= number; i++)
    {
    sum = sum * i;
    }
    return sum;
}

// Попробовать альтернативное решение:
// Console.WriteLine("Введите число");
// bool isParsed = int.TryParse(Console.ReadLine(), out int number);



// if(!isParsed)
// {
//     Console.WriteLine("Введено неправильное значение");
//     return;
// }
// else
// {
//     int f = Factorial(number);
//     Console.WriteLine(f);

// }

// int Factorial(int number)
// {
//     if((number == 0) || (number == 1))
//     {
//         return 1;
//     }
//     return number * (Factorial(number));
// }