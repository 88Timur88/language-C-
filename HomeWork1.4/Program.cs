// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Ввведите положительное число ==> ");
int N = int.Parse(Console.ReadLine());
int b = 1;

if(N > 0)
    while (b <= N)
    {
        if(b % 2 == 0)
        {
            Console.WriteLine(b);
            b = b + 1;
        }
        b = b + 1;
    }
else
    Console.WriteLine("Введено отрицательное число");