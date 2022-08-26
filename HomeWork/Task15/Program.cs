// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру");
bool isNumber = int.TryParse(Console.ReadLine(), out int x);

if(isNumber!= true)
{
    Console.WriteLine("Нужно вводить цифру");
    return;
}

bool isValid = Validate(x);

if (isValid == false)
{
    Console.WriteLine("Неверная цифра");
    return;
}
    
bool Validate(int x)
{
    if(x < 1 || x > 7)
    {
        return false;
    }
    return true;
}


string GetNumber(int arg)
{
    if(arg == 6 || arg == 7)
    {
        return "да";
    }
    return "нет";
}

string result = GetNumber(x);
Console.WriteLine(result);
