// SeeНапишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между ними в 2D пространстве.
// 
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21
/*Console.WriteLine("Введите координаты точки А");
bool isParsedX1 = double.TryParse(Console.ReadLine(), out double x1);
bool isParsedY1 = double.TryParse(Console.ReadLine(), out double y1);

Console.WriteLine("Введите координаты точки В");
bool isParsedX2 = double.TryParse(Console.ReadLine(), out double x2);
bool isParsedY2 = double.TryParse(Console.ReadLine(), out double y2);

if(!isParsedX1 && !isParsedY1 && !isParsedX2 && !isParsedY2)
{
    Console.WriteLine("Координаты ввели не корректно");
}


double b = (x2-x1)*(x2-x1);
double c = (y2-y1)*(y2-y1);

double distance = GetDistanceBetweenPoints(x1, y1, x2, y2);
Console.WriteLine(distance);

if(b != c && b != 0 && c != 0)
{
    int distance = Math.Sqrt(b + c);
}
return;*/

int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());

int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double result = GetDistanceBetweenPoints(x1, y1, x2, y2);
Console.WriteLine(result);

double GetDistanceBetweenPoints(int x1, int y1, int x2, int y2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2)+ Math.Pow(y2 - y1, 2)), 2);
}