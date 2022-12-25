// 

bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if(!isParsed)
{
    Console.WriteLine("Incorrect number");
    return;
}

int sum = GetSumOfNumbersInInterval(number);

Console.WriteLine(sum);

int GetSumOfNumbersInInterval(int number)
{
    int sum = 0;
    for(var i = 1; i <= number; i++)
    {
        sum+= i;
    }
    return sum;
}