// Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка);

int a = int.Parse(Console.ReadLine());
int b = 2;

int res = a % b;

if(res == 0) Console.WriteLine("Yes");
else
{
    Console.WriteLine("No");
}