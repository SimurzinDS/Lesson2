Console.WriteLine("Введите x1");
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int x1);
Console.WriteLine("Введите x2");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int x2);
Console.WriteLine("Введите y1");
bool isNumberY1 = int.TryParse(Console.ReadLine(), out int y1);
Console.WriteLine("Введите x1");
bool isNumberY2 = int.TryParse(Console.ReadLine(), out int y2);

if (isNumberX1 == false || isNumberX2 == false || isNumberY1 == false || isNumberY2 == false)
{
    Console.WriteLine("Неверный ввод");
    return;
}

double result = Get(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками равно  {result}");

double Get(int x1, int x2, int y1, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}
