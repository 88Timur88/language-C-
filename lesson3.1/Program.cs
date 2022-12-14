bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

if(!isParsedX && !isParsedY)
{
    Console.WriteLine("Координаты ввели не корректно");
    return;
}
int quarterNumber = GetQuarterNumberByCoordinates(x,y);
if(quarterNumber == -1)
{
    Console.WriteLine("Координаты равны нулю");
    return;
}
Console.WriteLine(quarterNumber);

int GetQuarterNumberByCoordinates(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }
    if(x < 0 && y > 0)
    {
        return 2;
    }
    if(x < 0 && y < 0)
    {
        return 3;
    }
    if(x > 0 && y < 0)
    {
        return 4;
    }

    return -1;
}