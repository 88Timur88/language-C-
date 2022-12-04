// See https://aka.ms/new-console-template for more information
// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго

int numberA = int.Parse(Console.ReadLine());
int numberB = int.Parse(Console.ReadLine());

int work = numberB*numberB;

if(work == numberA)
{
    Console.WriteLine("Yes");       
}
else
{
    Console.Write("No");
}
