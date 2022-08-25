// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
bool isNumber = int.TryParse(Console.ReadLine(), out int x);


string GetNumber(int arg)
{
    if(arg == 6 && arg == 7)
    {
        return "да";
    }
    else
    {
        if(x < 1 || x > 7)
        {
            return "Неверное число";
        }
  

    }
    return "нет";
}

string result = GetNumber(x);
Console.WriteLine(result);
