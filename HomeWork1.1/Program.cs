// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее

int numberA = int.Parse(Console.ReadLine());

int numberB = int.Parse(Console.ReadLine());

if(numberA < numberB)
{
    Console.WriteLine(numberB);
}
else
{
    Console.WriteLine(numberA);
}