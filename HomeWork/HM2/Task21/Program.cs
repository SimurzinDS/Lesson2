Console.WriteLine("Введите x1");
bool isNumberX1 = int.TryParse(Console.ReadLine(), out int x1);
Console.WriteLine("Введите y1");
bool isNumberY1 = int.TryParse(Console.ReadLine(), out int y1);
Console.WriteLine("Введите z1");
bool isNumberZ1 = int.TryParse(Console.ReadLine(), out int z1);
Console.WriteLine("Введите x2");
bool isNumberX2 = int.TryParse(Console.ReadLine(), out int x2);
Console.WriteLine("Введите y2");
bool isNumberY2 = int.TryParse(Console.ReadLine(), out int y2);
Console.WriteLine("Введите z2");
bool isNumberZ2 = int.TryParse(Console.ReadLine(), out int z2);

if (isNumberX1 == false || isNumberX2 == false || isNumberY1 == false || isNumberY2 == false || isNumberZ1 == false || isNumberZ2 == false)
{
    Console.WriteLine("Неверный ввод");
    return;
}

double result = Get(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками равно  {result}");

double Get(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
}
