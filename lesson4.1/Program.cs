/* Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3 78 -> 2 89126 -> 5 */

bool isParsed = int.TryParse(Console.ReadLine(), out int a);

if(!isParsed)
{
    Console.WriteLine("Введено неправильное значение");
    return;
}

string str = a.ToString();
Char[] c = new Char[str.Length];
int count = 0;
for (int i = 0; i < str.Length; i++)
{
    c[i] = str[i];
    count++;
}
Console.WriteLine(count);